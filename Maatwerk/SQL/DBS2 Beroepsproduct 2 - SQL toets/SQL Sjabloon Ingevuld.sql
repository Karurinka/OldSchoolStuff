-- Studentnummer:2824361
-- Naam: Michelle Broens
-- Klas: S21M
-- Vakdocent: n.v.t.

-- Opgave 1
SELECT
	g.Beschrijving, ISNULL(g2.Beschrijving, '-')
FROM
	Genre g
	LEFT JOIN Genre g2 ON g2.ID = g.SubGenreVanID_GenreID
	;	

-- Opgave 2a
SELECT
	s.Titel, ss.AanvangstDatumTijd AS Aanvang, gs.GemetenSpeeltijd
FROM
	Spel s
	LEFT JOIN GespeeldSpel gs ON s.ID = gs.SpelID
	LEFT JOIN SpeelSessie ss ON gs.SessieID = ss.ID
WHERE 
	gs.GemetenSpeeltijd > s.NormaleSpeelDuur * 1.1
	ORDER BY
	ss.AanvangstDatumTijd DESC
	;	

-- Opgave 2b
--ik heb veel gezocht naar het splitsen van een kolom
--dit is de beste optie die ik kon vinden
--maar dit is niet helemaal goed gelukt
SELECT CASE
	WHEN ss.AanvangstDatumTijd LIKE '____-__-__%' THEN LEFT(ss.AanvangstDatumTijd, CHARINDEX('___-__-__', ss.AanvangstDatumTijd) -1)

	ELSE ss.AanvangstDatumTijd
	END,
CASE 
	WHEN ss.AanvangstDatumTijd LIKE '%__:__' THEN RIGHT(ss.AanvangstDatumTijd, CHARINDEX('__:__', REVERSE(ss.AanvangstDatumTijd)) -1)
	END
	FROM 
	Spel s
	LEFT JOIN GespeeldSpel gs ON s.ID = gs.SpelID
	LEFT JOIN SpeelSessie ss ON gs.SessieID = ss.ID
	;

-- Opgave 3
SELECT
	s.Titel, COUNT(s.ID) AS AantalKeerGespeeld
FROM
	Spel s
	LEFT JOIN GespeeldSpel gs ON s.ID = gs.SpelID
	GROUP BY 
		s.Titel
	HAVING COUNT(s.ID) >= 2
	ORDER BY
		AantalKeerGespeeld ASC	
	;

-- Opgave 4
SELECT
	ss.AanvangstDatumTijd AS Moment,
	s.Titel AS Spel,
	p.Naam AS Winnaar,
	gs.GemetenSpeeltijd,
	COUNT(d.SpelerID) -1 AS Tegenstanders
FROM
	Spel s
	INNER JOIN GespeeldSpel gs ON s.ID = gs.SpelID
	INNER JOIN Speler p ON gs.Winnaar_SpelerID = p.ID
	INNER JOIN SpeelSessie ss ON gs.SessieID = ss.ID
	INNER JOIN Deelnemer d ON s.ID = d.SpelerID
GROUP BY 
	ss.ID,
	ss.AanvangstDatumTijd,
	s.Titel,
	p.Naam,
	gs.GemetenSpeeltijd
ORDER BY
	gs.GemetenSpeeltijd DESC
	;

-- Opgave 5a
ALTER TABLE
	Spel
ADD 
	IdeaalAantalSpelers int
	;

ALTER TABLE
	Spel
ADD CONSTRAINT 
	Chk_BetweenMaxAndMin
CHECK 
	(IdeaalAantalSpelers BETWEEN SpelersMin AND SpelersMax)
	;

-- Opgave 5b
INSERT INTO Spel VALUES(5,'Fe', 'test', 1, 4, 90, 3) --deze insert moet goed gaan
INSERT INTO Spel VALUES(5,'Pe', 'test', 1, 4, 90, 5) --deze insert moet falen
;

-- Opgave 5c
UPDATE
	Spel
SET IdeaalAantalSpelers = CEILING(ROUND(SpelersMax + SpelersMin / 2, 0))

-- Opgave 6
--als je hier een constraint voor gaat maken
--moet je kijken of de winnaar in de deelnemer tabel zit
--als ik dit zou doen zou dit waarschijnlijk een procedure worden 
--en dan is het niet echt een constraint meer
--dus dit zal niet lukken in een constraint
--zo zal de procedure er dan ongever uit zien
CREATE PROCEDURE 
Chk_WinnaarInDeelnemers(
@WinnaarID bit
)
AS
BEGIN
IF
	BEGIN
		(SELECT
			gs.Winnaar_SpelerID
		FROM
			GespeeldSpel gs
			INNER JOIN SpeelSessie ss ON gs.SessieID = ss.ID
			INNER JOIN Deelnemer d ON ss.ID = d.SessieID
		WHERE
			gs.Winnaar_SpelerID = d.SpelerID)
		@WinnaarID = 1
	END
@WinnaarID = 0
	;
