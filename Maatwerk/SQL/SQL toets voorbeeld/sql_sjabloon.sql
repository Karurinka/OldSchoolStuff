-- Opgave 1
SELECT 
	ho.Omschrijving AS Huurobject, h.Voornaam + ' ' + h.Naam AS Huurdernaam
FROM 
	Huurobject ho
	LEFT JOIN Extra e ON ho.ID = e.HuurobjectID
	LEFT JOIN Huurovereenkomst hok ON e.Factuurnummer = hok.Factuurnummer
	LEFT JOIN Huurder h ON h.Relatienummer = hok.HuurderRelatienummer
ORDER BY 
ho.Omschrijving ASC, Huurdernaam ASC;

-- Opgave 2
SELECT 
	ho.Omschrijving AS Huurobject, ho2.Omschrijving AS Benodigd, 
	ho.PrijsPerDag + ho2.PrijsPerDag AS Totaalprijs
FROM 
	Huurobject ho 
	LEFT JOIN Huurobject ho2 ON ho.HuurobjectID_Benodigd = ho2.ID
ORDER BY
	Totaalprijs DESC;

-- Opgave 3
SELECT a.Woonplaats, COUNT(*) AS #Klanten
FROM 
	Huurder h
	INNER JOIN Adres a ON h.AdresID = a.ID
	GROUP BY a.Woonplaats
	HAVING COUNT(*) > 2;

-- Opgave 4
SELECT v.Kenteken, vt.Omschrijving, vt.PrijsPerDag
FROM 
	Voertuig v
	LEFT JOIN Voertuigtype vt ON v.VoertuigtypeID = vt.ID
WHERE
	vt.PrijsPerDag < 200 AND vt.MetTrekhaak = 1
	OR
	vt.PrijsPerDag > 700;

-- Opgave 5
SELECT 
	ho.Factuurnummer, DATEDIFF(day, ho.VanDatum, ho.TotDatum) AS Huurperiode
FROM 
	Huurovereenkomst ho
	INNER JOIN Voertuig v ON ho.VoertuigID = v.ID
WHERE 
	DATEDIFF(day, ho.VanDatum, ho.TotDatum) = 
		(SELECT MAX(DATEDIFF(day, ho2.VanDatum, ho2.TotDatum))
		 FROM
			Huurovereenkomst ho2
			INNER JOIN Voertuig v2 ON ho2.VoertuigID = v2.ID
		 WHERE v.VoertuigtypeID = v2.VoertuigtypeID);

-- Opgave 6
ALTER TABLE
	Voertuig
ADD CONSTRAINT 
	Chk_Kenteken
	CHECK (Kenteken LIKE '_-___-__');

INSERT INTO Voertuig VALUES(1, 'AA-B-C'); -- Deze moet falen

-- Opgave 7
UPDATE 
	Voertuigtype
SET 
	PrijsPerDag = PrijsPerDag * 0.90
WHERE
	ID NOT IN	(SELECT
					hok.VoertuigID
				 FROM
					Huurovereenkomst hok
					INNER JOIN Voertuig v ON hok.VoertuigID = v.ID);

-- Opgave 8
SELECT 
	hok.Factuurnummer, SUM(hob.PrijsPerDag) * DATEDIFF(DAY, hok.VanDatum, hok.TotDatum) +
	vt.PrijsPerDag * DATEDIFF(DAY, hok.VanDatum, hok.TotDatum) AS Totaalprijs
FROM 
	Huurovereenkomst hok
	INNER JOIN Extra e ON hok.Factuurnummer = e.Factuurnummer
	INNER JOIN Huurobject hob ON e.HuurobjectID = hob.ID
	INNER JOIN Voertuig v ON hok.VoertuigID = v.ID
	INNER JOIN Voertuigtype vt ON v.VoertuigtypeID = vt.ID
	GROUP BY
		hok.Factuurnummer, hok.VanDatum, hok.TotDatum, vt.PrijsPerDag
	ORDER BY
		hok.Factuurnummer ASC 