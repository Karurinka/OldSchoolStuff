-- Spellenvereniging 'De Hoogste Worp' is bezig met het opzetten van een systeem waarmee hun leden speelsessies
-- voor hun favoriete spel kunnen plannen. Ze hebben een prototype opgezet waarmee ze aan het testen zijn. 

--'De Hoogste Worp' is een kleine club, maar hoopt met deze professionalisering meer leden aan te kunnen trekken.
-- Het moet gemakkelijk zijn om sessies te organiseren waarin spelers samen een of meerdere spellen gaan spelen. 
-- Aan de sessie kunnen naast leden van de spellenvereniging ook gasten meedoen. Daarnaast is het dat er een historie wordt bijgehouden 
-- zodat elke speler kan zien welke sessies zij of hij in het verleden heeft gespeeld, welke spellen er gespeeld werd, 
-- en welke speler de winnaar was van de gespeelde spellen. Ook vinden de statistiek-nerds binnen de vereniging het leuk
-- om te weten hoe lang het spel duurde. 

-- Versie 5

DROP TABLE Deelnemer;
DROP TABLE GespeeldSpel;
DROP TABLE SpeelSessie;
DROP TABLE Speler;
DROP TABLE SpelGenre;
DROP TABLE Genre;
DROP TABLE Spel;
DROP TABLE Uitgever;
GO

CREATE TABLE Uitgever (
  ID int PRIMARY KEY IDENTITY(1,1) ,
  Naam nvarchar(100) NOT NULL,
  Website nvarchar(255) NULL,
);

SET IDENTITY_INSERT Uitgever ON;
INSERT INTO Uitgever (Id, Naam, Website) VALUES (1,'999 Games', 'http://www.999games.nl/');
INSERT INTO Uitgever (Id, Naam, Website) VALUES (2,'Ravensburger',  'http://www.ravensburger.com/');
INSERT INTO Uitgever (Id, Naam, Website) VALUES (3,'FryxGames',  'http://www.fryxgames.se/');
INSERT INTO Uitgever (Id, Naam, Website) VALUES (4,'Steve Jackson Games',  'http://www.sjgames.com');
INSERT INTO Uitgever (Id, Naam, Website) VALUES (5,'White Goblin Games',  'http://www.whitegoblingames.com/');
SET IDENTITY_INSERT Uitgever OFF;

CREATE TABLE Spel (
  ID int PRIMARY KEY IDENTITY(1,1),
  UitgeverID int NOT NULL REFERENCES Uitgever(ID),
  Titel nvarchar(255) NOT NULL,
  Omschrijving nvarchar(max) NULL,
  SpelersMin int NOT NULL,
  SpelersMax int NOT NULL,
  NormaleSpeelDuur int NULL
);

SET IDENTITY_INSERT Spel ON;
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (1,1,'Dominion', 'In dit spel probeer je tijdens het spel een zo sterk mogelijk deck te formeren, zodat jij aan het einde van het spel de meeste punten hebt.', 2, 4, 30);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (2,1,'Carcassonne', 'In dit spel bouwen de spelers gezamenlijk de Franse stad Carcassonne op met al haar wegen, steden, kloosters en weiden. Door het inzetten van horigen scoren ze punten voor afgebouwde projecten. ', 3, 5, 35);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (3,1,'Regenwormen', 'Verzamel zoveel mogelijk regenwormen in dit snelle dobbelspel.', 2, 7, 20);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (4,1,'Brug naar de Hemel', 'Als inwoners van Kingsbridge moeten de spelers de welvaar in het stadje laten groeien.', 2, 4, 90);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (5,2,'Puerto Rico', 'In Puerto Rico nemen spelers de rol van koloniale gouverneurs op het eiland Puerto Rico aan. Doel van het spel is zoveel mogelijk punten te verzamelen door goederen naar Europa te verschepen of gebouwen neer te zetten.', 2, 5, 120);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (6,2,'Koehandel', 'Éénmaal! Andermaal! Verkocht! Wie is de gelukkige eigenaar van de prijskoe Bertha of één van de andere dieren?', 3, 5, 45);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (7,2,'Barricade Classic', ' Alle wegen zouden naar hetzelfde doel moeten leiden...... maar je loopt nog niet voorop of je medespelers leggen barricades in de weg.', 2, 4, 60);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (8,3,'Terraforming Mars', 'In het jaar 2400 begint de mens met het leefbaar maken van Mars. Grote bedrijven, waarvan jij er een speelt, beginnen projecten die hieraan bijdragen.', 1, 5, 120);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (9,3,'Wilderness', 'Je wordt voor dood achtergelaten in niemandsland. Zonder kleding of hulpmiddelen, moet je proberen terug te komen naar de beschaafde wereld voor je het loodje legt.', 2, 8, 60);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (10,4,'Munchkin', ' Vecht met monsters, verover de schat en pak ook de schat van je teamgenoten af. Alles om maar tot niveau tien te komen en het spel te winnen is geoorloofd.', 3, 6, 90);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (11,4,'Revolution!', 'Chanteer de drukker. Bedreig de herbergier. Koop de priester om. Welkom bij Revolution! ', 3, 4, 60);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (12,4,'Munchkin Cthulhu', 'Ph''nglui mglw''nafh Cthulhu R''lyeh wgah''nagl fhtagn', 3, 4, 60);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (13,5,'Terra Mystica', 'In het land van Terra Mystica lopen 14 verschillende volkeren rond. Dat geeft natuurlijk allerlei spanningen...', 2, 5, 120);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (14,5,'Scythe', 'Een tijd van onrust in het Europa van 1920. De as van WOI dampt nog na. Vijf facties strijden om de macht.', 1, 5, 100);
INSERT INTO Spel (ID, UitgeverID, Titel, Omschrijving, SpelersMin, SpelersMax, NormaleSpeelDuur) VALUES (15,5,'Fields of Arle', 'In de velden van Oost-Friesland, Duitsland, proberen de spelers hun landgoederen te laten groeien en bloeien.', 1, 2, 90);
SET IDENTITY_INSERT Spel OFF;

CREATE TABLE Genre (
  ID int PRIMARY KEY IDENTITY(1,1),
  SubGenreVanID_GenreID int NULL references Genre(ID),
  Beschrijving nvarchar(255) NOT NULL
)

SET IDENTITY_INSERT Genre ON;
INSERT INTO Genre (ID, Beschrijving, SubGenreVanID_GenreID) VALUES (1,'Kaartspel',NULL);
INSERT INTO Genre (ID, Beschrijving, SubGenreVanID_GenreID) VALUES (2,'Bordspel',NULL);
INSERT INTO Genre (ID, Beschrijving, SubGenreVanID_GenreID) VALUES (3,'Legspel',NULL);
INSERT INTO Genre (ID, Beschrijving, SubGenreVanID_GenreID) VALUES (4,'Deckbuilding',1);
INSERT INTO Genre (ID, Beschrijving, SubGenreVanID_GenreID) VALUES (5,'Klassiek',2);
INSERT INTO Genre (ID, Beschrijving, SubGenreVanID_GenreID) VALUES (6,'Pesten',NULL);
INSERT INTO Genre (ID, Beschrijving, SubGenreVanID_GenreID) VALUES (7,'Kansspel',NULL);
INSERT INTO Genre (ID, Beschrijving, SubGenreVanID_GenreID) VALUES (8,'Resource Management',NULL);
INSERT INTO Genre (ID, Beschrijving, SubGenreVanID_GenreID) VALUES (9,'Overleven',NULL);
SET IDENTITY_INSERT Genre OFF;

CREATE TABLE SpelGenre (
  SpelID int NOT NULL REFERENCES Spel(ID),
  GenreID int NOT NULL REFERENCES Genre(ID),
  PRIMARY KEY (SpelId, GenreID)
);

INSERT INTO SpelGenre VALUES (1,1);
INSERT INTO SpelGenre VALUES (1,4);
INSERT INTO SpelGenre VALUES (2,3);
INSERT INTO SpelGenre VALUES (2,8);
INSERT INTO SpelGenre VALUES (3,3);
INSERT INTO SpelGenre VALUES (3,6);
INSERT INTO SpelGenre VALUES (4,2);
INSERT INTO SpelGenre VALUES (4,8);
INSERT INTO SpelGenre VALUES (5,2);
INSERT INTO SpelGenre VALUES (5,8);
INSERT INTO SpelGenre VALUES (6,1);
INSERT INTO SpelGenre VALUES (7,2);
INSERT INTO SpelGenre VALUES (7,5);
INSERT INTO SpelGenre VALUES (8,2);
INSERT INTO SpelGenre VALUES (8,8);
INSERT INTO SpelGenre VALUES (9,2);
INSERT INTO SpelGenre VALUES (9,9);
INSERT INTO SpelGenre VALUES (10,1);
INSERT INTO SpelGenre VALUES (11,1);
INSERT INTO SpelGenre VALUES (12,1);
INSERT INTO SpelGenre VALUES (13,2);
INSERT INTO SpelGenre VALUES (14,1);
INSERT INTO SpelGenre VALUES (15,1);

CREATE TABLE Speler (
  ID int PRIMARY KEY IDENTITY(1,1),
  Naam nvarchar(255) NOT NULL,
  LidNummer int NULL, -- er kunnen ook gasten mee spelen
  Woonplaats nvarchar(255) NULL,
  Geboortedatum datetime NULL,
  Emailadres nvarchar(1024) NOT NULL
);

SET IDENTITY_INSERT Speler ON;
INSERT INTO Speler (ID, Naam, LidNummer, Woonplaats, Geboortedatum, Emailadres) VALUES(1,'Anton Aardnoot', 3145, 'Eindhoven', '1977-04-01', 'aardnoot@tipsyduck.nl');
INSERT INTO Speler (ID, Naam, LidNummer, Woonplaats, Geboortedatum, Emailadres) VALUES(2,'Barry Boggle', 8132, 'Geldrop', '1988-07-14', 'b.boggle@provider.net');
INSERT INTO Speler (ID, Naam, LidNummer, Woonplaats, Geboortedatum, Emailadres) VALUES(3,'Chris Cantaloupe', NULL, 'Nuenen', '1991-11-13', 'chrisje441@hootmail.com');
INSERT INTO Speler (ID, Naam, LidNummer, Woonplaats, Geboortedatum, Emailadres) VALUES(4,'Dirk Drijver', NULL, 'Veldhoven', '1998-01-15', 'ddddrijver@drijver.cd');
INSERT INTO Speler (ID, Naam, LidNummer, Woonplaats, Geboortedatum, Emailadres) VALUES(5,'Edith Elkerlijk', 9973, 'Eindhoven', '1983-08-23', 'editje18@ziggo.nl');
INSERT INTO Speler (ID, Naam, LidNummer, Woonplaats, Geboortedatum, Emailadres) VALUES(6,'Frits Franssen', 1423, 'Budel', '1965-12-31', 'f.h.g.franssen@tue.nl');
SET IDENTITY_INSERT Speler OFF;

CREATE TABLE SpeelSessie (
  ID INT PRIMARY KEY IDENTITY(1,1),
  Organisator_SpelerID int NOT NULL REFERENCES Speler(ID),
  AanvangstDatumTijd datetime NOT NULL,
  Locatie nvarchar(255) NOT NULL
);

SET IDENTITY_INSERT SpeelSessie ON;
INSERT INTO SpeelSessie (ID, AanvangstDatumTijd, Locatie, Organisator_SpelerID) VALUES(1,'2017-01-03 20:00', 'Eindhoven', 1);
INSERT INTO SpeelSessie (ID, AanvangstDatumTijd, Locatie, Organisator_SpelerID) VALUES(2,'2017-01-12 19:30', 'Veldhoven', 2);
INSERT INTO SpeelSessie (ID, AanvangstDatumTijd, Locatie, Organisator_SpelerID) VALUES(3,'2017-02-03 21:15', 'Eindhoven', 5);
INSERT INTO SpeelSessie (ID, AanvangstDatumTijd, Locatie, Organisator_SpelerID) VALUES(4,'2017-05-01 14:30', 'Nuenen', 5);
INSERT INTO SpeelSessie (ID, AanvangstDatumTijd, Locatie, Organisator_SpelerID) VALUES(5,'2017-06-13 17:45', 'Eindhoven', 6);
SET IDENTITY_INSERT SpeelSessie OFF;

CREATE TABLE GespeeldSpel (
  SessieID int NOT NULL REFERENCES SpeelSessie(ID),
  SpelID int NOT NULL REFERENCES Spel(ID),
  Winnaar_SpelerID int NULL REFERENCES Speler(ID),
  GemetenSpeeltijd INT NULL,
  PRIMARY KEY(SessieID, SpelID)
);

INSERT INTO GespeeldSpel VALUES (1,1,1,32);
INSERT INTO GespeeldSpel VALUES (1,2,2,45);
INSERT INTO GespeeldSpel VALUES (1,3,3,110);
INSERT INTO GespeeldSpel VALUES (2,4,1,135);
INSERT INTO GespeeldSpel VALUES (2,5,4,88);
INSERT INTO GespeeldSpel VALUES (2,6,1,20);
INSERT INTO GespeeldSpel VALUES (2,7,1,63);
INSERT INTO GespeeldSpel VALUES (2,1,4,38);
INSERT INTO GespeeldSpel VALUES (2,8,1,75);
INSERT INTO GespeeldSpel VALUES (3,9,5,15);
INSERT INTO GespeeldSpel VALUES (3,10,4,45);
INSERT INTO GespeeldSpel VALUES (3,1,4,59);
INSERT INTO GespeeldSpel VALUES (4,1,NULL,NULL);
INSERT INTO GespeeldSpel VALUES (4,7,NULL,NULL);
INSERT INTO GespeeldSpel VALUES (4,9,NULL,NULL);

CREATE TABLE Deelnemer (
  SessieID int NOT NULL REFERENCES SpeelSessie(ID),
  SpelerID int NOT NULL REFERENCES Speler(ID),
  PRIMARY KEY (SessieID, SpelerID)
);

INSERT INTO Deelnemer VALUES (1,1);
INSERT INTO Deelnemer VALUES (1,2);
INSERT INTO Deelnemer VALUES (1,3);
INSERT INTO Deelnemer VALUES (1,4);
INSERT INTO Deelnemer VALUES (2,2);
INSERT INTO Deelnemer VALUES (2,1);
INSERT INTO Deelnemer VALUES (2,4);
INSERT INTO Deelnemer VALUES (2,6);
INSERT INTO Deelnemer VALUES (3,4);
INSERT INTO Deelnemer VALUES (3,5);
INSERT INTO Deelnemer VALUES (4,1);
INSERT INTO Deelnemer VALUES (4,2);
INSERT INTO Deelnemer VALUES (4,3);
INSERT INTO Deelnemer VALUES (4,4);
INSERT INTO Deelnemer VALUES (4,5);
INSERT INTO Deelnemer VALUES (4,6);
INSERT INTO Deelnemer VALUES (5,6);
INSERT INTO Deelnemer VALUES (5,1);