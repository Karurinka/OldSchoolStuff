-- Opgave 1
DROP TABLE [Observation]
DROP TABLE [Animal]
DROP TABLE [Species]
DROP TABLE [Spot]
DROP TABLE [Ranger]

CREATE TABLE [Ranger](
[BadgeID] int NOT NULL PRIMARY KEY,
[Name] varchar(20) NOT NULL,
[Birthday] date NOT NULL,
[Position] varchar(7) NOT NULL,
[Nickname] varchar(20),
[Password] varchar(20) NOT NULL,
);

CREATE TABLE [Spot](
[ID] int PRIMARY KEY,
[Description] varchar(80),
[Location] varchar(20) NOT NULL UNIQUE
);

CREATE TABLE [Species](
[ID] int PRIMARY KEY,
[Description] varchar(80) NOT NULL UNIQUE,
[SubspeciesID] int 
);

CREATE TABLE [Animal](
[ID] int PRIMARY KEY,
[Name] varchar(20) NOT NULL,
[SpeciesID] int FOREIGN KEY REFERENCES [Species]([ID])
);

CREATE TABLE [Observation](
[RangerBadgeID] int FOREIGN KEY REFERENCES [Ranger]([BadgeID]),
[AnimalID] int FOREIGN KEY REFERENCES [Animal]([ID]),
[SpotID] int FOREIGN KEY REFERENCES [Spot]([ID]),
[ObservationDate] date,
[Count] int,
[Remarks] varchar(80)
);

ALTER TABLE [Ranger]
ADD CONSTRAINT chk_RangerID
CHECK(BadgeID > 1000);

ALTER TABLE [Ranger]
ADD CONSTRAINT chk_Password
CHECK([Password] < 42);

ALTER TABLE [Ranger]
ADD CONSTRAINT chk_Password_And_Nickname
CHECK([Password] != Nickname);

ALTER TABLE [Observation]
ADD CONSTRAINT chk_Count
CHECK([Count] > 0);

ALTER TABLE [Species]
ADD CONSTRAINT chk_SubSpeciesID
CHECK(ID != SubspeciesID);

-- Opgave 2a
SELECT c.name, t.name
FROM Character c
INNER JOIN Player p ON c.player_email = p.email
INNER JOIN CharacterInTeam cit ON c.id = cit.character_id
INNER JOIN Team t ON cit.team_name = t.name
WHERE c.health > (SELECT AVG(c.health) FROM Character c
		INNER JOIN Player p ON c.player_email = p.email)
AND t.color = 'Rood' OR t.altcolor = 'Rood';

-- Opgave 2b
SELECT b.BATTLEDATE, t.color
FROM Battle b, Team t
INNER JOIN CharacterInTeam cit ON t.name = cit.team_name
INNER JOIN Character c ON cit.character_id = c.id
WHERE BATTLEDATE BETWEEN GETDATE()-7 AND GETDATE()+7
AND c.name LIKE ('%Goblin%');

-- Opgave 2c
SELECT p.email, c.name
FROM Character c
INNER JOIN Player p ON c.player_email = p.email
WHERE c.attack (SELECT MAX(c.attack) 
				FROM Character c)
ORDER BY p.email, c.name;

-- Opgave 2d
SELECT t.name, COUNT(*) AS Winst
FROM Team t
INNER JOIN Battle b ON b.team_name_winning = t.name
GROUP BY t.name
ORDER BY Winst DESC;

-- Opgave 2e
SELECT c.name, COUNT(*) AS Aantalwedstrijden
FROM Character c
INNER JOIN CharacterInTeam cit ON c.id = cit.character_id
INNER JOIN Team t ON cit.team_name = t.name
INNER JOIN Battle b ON t.name = b.team_name_1 OR t.name = b.team_name_2 
GROUP BY c.name
ORDER BY Aantalwedstrijden DESC;

-- Opgave 2f
SELECT t.name, t.color, t.altcolor
FROM Team t
LEFT JOIN Battle b ON t.name = b.team_name_1 OR t.name =b.team_name_2
WHERE b.team_name_1 LIKE t.name
OR b.team_name_2 LIKE t.name
ORDER BY t.name;