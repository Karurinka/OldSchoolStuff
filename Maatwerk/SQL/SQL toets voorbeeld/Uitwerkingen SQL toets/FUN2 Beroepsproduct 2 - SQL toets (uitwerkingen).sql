-- Opdracht 1
SELECT
  o.Omschrijving AS Huurobject,
  h.Voornaam + ' ' + h.Naam AS Huurder
FROM
  Huurobject o LEFT JOIN
  Extra e ON o.ID = e.HuurobjectID LEFT JOIN
  Huurovereenkomst ho ON ho.Factuurnummer = e.Factuurnummer LEFT JOIN
  Huurder h ON h.Relatienummer = ho.HuurderRelatienummer
ORDER BY
  Huurobject ASC, Huurder ASC
;

-- Opdracht 2
SELECT
  o.Omschrijving AS Huurobject,
  b.Omschrijving AS Benodigd,
  o.PrijsPerDag + b.PrijsPerDag AS Totaalprijs
FROM
  Huurobject o LEFT JOIN
  Huurobject b ON o.HuurobjectID_Benodigd = b.ID
ORDER BY
  Totaalprijs DESC
;

-- Opdracht 3
SELECT a.Woonplaats, COUNT(*) AS "#Klanten"
FROM Adres a INNER JOIN Huurder h ON a.ID = h.AdresID
GROUP BY a.Woonplaats
HAVING COUNT(*) > 2
ORDER BY COUNT(*) ASC;

-- Opdracht 4
SELECT v.Kenteken, vt.Omschrijving, vt.PrijsPerDag
FROM Voertuig v INNER JOIN Voertuigtype vt ON v.VoertuigtypeID = vt.ID
WHERE (vt.PrijsPerDag < 200 AND vt.MetTrekhaak = 1) OR vt.PrijsPerDag > 700;

-- Opdracht 5
SELECT 
	ho.Factuurnummer, DATEDIFF(day, ho.VanDatum, ho.TotDatum) AS Huurperiode
FROM 
	Huurovereenkomst ho 
	INNER JOIN Voertuig v ON ho.VoertuigID = v.ID
WHERE 
	DATEDIFF(day, ho.VanDatum, ho.TotDatum) = (
		SELECT MAX(DATEDIFF(day, ho2.VanDatum, ho2.TotDatum))
		FROM Huurovereenkomst ho2 INNER JOIN Voertuig v2 ON ho2.VoertuigID = v2.ID
		WHERE v.VoertuigtypeID = v2.VoertuigtypeID
);

-- Opdracht 6
ALTER TABLE Voertuig
ADD CONSTRAINT chk_VoertuigKenteken
CHECK (Kenteken LIKE '_-___-__');

INSERT INTO Voertuig VALUES (1, 'A-BC-DEF'); -- Ter controle: moet falen

-- Opdracht 7
UPDATE Voertuigtype
SET PrijsPerDag = PrijsPerDag * 0.9
WHERE ID NOT IN (
  SELECT VoertuigtypeID
  FROM
    Huurovereenkomst ho INNER JOIN
    Voertuig v ON ho.VoertuigID = v.ID
);

SELECT * FROM Voertuigtype; -- Motorboot moet nu 720 per dag kosten

-- Opdracht 8
SELECT
  ho.Factuurnummer,
  SUM(o.PrijsPerDag) * DATEDIFF(day, ho.VanDatum, ho.TotDatum) +
    vt.PrijsPerDag * DATEDIFF(day, ho.VanDatum, ho.TotDatum)
	AS Totaalprijs
FROM
  Huurovereenkomst ho INNER JOIN
  Voertuig v ON v.ID = ho.VoertuigID INNER JOIN
  Voertuigtype vt ON vt.ID = v.VoertuigtypeID INNER JOIN
  Extra e ON e.Factuurnummer = ho.Factuurnummer INNER JOIN
  Huurobject o ON o.ID = e.HuurobjectID
GROUP BY ho.Factuurnummer, ho.VanDatum, ho.TotDatum, vt.PrijsPerDag
ORDER BY ho.Factuurnummer;