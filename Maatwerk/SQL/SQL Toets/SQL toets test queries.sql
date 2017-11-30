--query 1
--kijk per speler hoe vaak deze een spel gewonnen heeft
SELECT 
	p.Naam, COUNT(*) AS AantalKeerGewonnen
FROM 
	Speler p
	LEFT JOIN GespeeldSpel gs ON p.ID = gs.Winnaar_SpelerID
	GROUP BY 
		p.Naam
	ORDER BY
		AantalKeerGewonnen DESC
	;

--query 2
--kijk welk spel het meest gespeeld wordt door de winnaars
SELECT 
	p.Naam, s.Titel, COUNT(s.Titel) AS AantalKeerGespeeld
FROM
	Speler p
	INNER JOIN GespeeldSpel gs ON p.ID = gs.Winnaar_SpelerID
	INNER JOIN Spel s ON gs.SpelID = s.ID
	GROUP BY
		s.Titel, p.Naam
	ORDER BY
		AantalKeerGespeeld DESC
	;

--query 3
--laat alle spellen die een deelnemer heeft gespeeld
--waarbij de gemeten tijd > 30
SELECT 
	s.Titel, p.Naam, s.NormaleSpeelDuur
FROM 
	Speler p
	LEFT JOIN GespeeldSpel gs ON p.ID = gs.Winnaar_SpelerID
	LEFT JOIN Spel s ON gs.SpelID = s.ID
WHERE
	NormaleSpeelDuur > 30
	;

--query 4
--geef per spel alle genres en sub-genres
SELECT
	s.Titel, g.Beschrijving
FROM
	Spel s
	INNER JOIN SpelGenre sg ON s.ID = sg.SpelID
	INNER JOIN Genre g ON sg.GenreID = g.ID
	;		

--query 5
--per uitgever
--de speler die het meeste gewonnen heeft
SELECT
	p.Naam, u.Naam, COUNT(p.naam) AS AantalKeerGewonnen
FROM
	Speler p
	INNER JOIN GespeeldSpel gs ON p.ID = gs.Winnaar_SpelerID
	INNER JOIN Spel s ON gs.SpelID = s.ID
	INNER JOIN Uitgever u ON s.UitgeverID = u.ID
WHERE 
	p.Naam = (SELECT 
				MAX(p2.Naam)
			  FROM
				Speler p2
				INNER JOIN GespeeldSpel gs2 ON p2.ID = gs2.Winnaar_SpelerID
				INNER JOIN Spel s2 ON gs2.SpelID = s2.ID
				INNER JOIN Uitgever u2 ON s.UitgeverID = u2.ID
			  WHERE
				p.Naam = p2.Naam
			  )
	GROUP BY
		p.Naam, u.Naam
	ORDER BY
		AantalKeerGewonnen DESC, u.Naam DESC, p.Naam DESC
	;			