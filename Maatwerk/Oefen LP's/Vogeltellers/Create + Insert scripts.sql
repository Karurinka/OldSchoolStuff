--Drop tables
DROP TABLE Bezoek_Waarneming
DROP TABLE Project_Bezoek
DROP TABLE Waarneming
DROP TABLE Vogelsoort
DROP TABLE Bezoek
DROP TABLE Project
DROP TABLE Teller

--Create tables
CREATE TABLE Teller(
ID int PRIMARY KEY,
Voornaam varchar(20),
Achternaam varchar(20),
Gebruikersnaam varchar(16),
Wachtwoord varchar(18)
);

CREATE TABLE Project(
ID int PRIMARY KEY,
Naam varchar(20),
GebiedNaam varchar(20),
Kaart varchar(MAX)
);

CREATE TABLE Bezoek(
ID int PRIMARY KEY,
BezoekNummer int,
AantalPunten int,
Datum date
);

CREATE TABLE Vogelsoort(
ID int PRIMARY KEY,
Naam varchar(20),
Afkorting varchar(4),
BroedStart date,
BroedEind date,
BroedpaarCijfer int
);

CREATE TABLE Waarneming(
ID int PRIMARY KEY,
Vogel_ID int FOREIGN KEY REFERENCES Vogelsoort(ID),
Categorie varchar(40),
Afkorting varchar(2),
Punten int
);

CREATE TABLE Project_Bezoek(
Project_ID int FOREIGN KEY REFERENCES Project(ID),
Bezoek_ID int FOREIGN KEY REFERENCES Bezoek(ID)
);

CREATE TABLE Bezoek_Waarneming(
Bezoek_ID int FOREIGN KEY REFERENCES Bezoek(ID),
Waarneming_ID int FOREIGN KEY REFERENCES Waarneming
);


--Inserts
--Teller
INSERT INTO Teller (ID, Voornaam, Achternaam, Gebruikersnaam, Wachtwoord)
					VALUES(1, 'Piet', 'Vogelsen', 'test', 'test1!');

--Project
INSERT INTO Project(ID, Naam, GebiedNaam, Kaart)
					VALUES(1, 'Test', 'Heide', 'Kaartje');

--Bezoek
INSERT INTO Bezoek (ID, BezoekNummer, AantalPunten, Datum)
					VALUES(1, 1, 0, CONVERT(datetime, GETDATE(), 110));
INSERT INTO Bezoek (ID, BezoekNummer, AantalPunten, Datum)
					VALUES(2, 2, 0, CONVERT(VARCHAR(10),GETDATE(), 110));
INSERT INTO Bezoek (ID, BezoekNummer, AantalPunten, Datum)
					VALUES(3, 3, 0, CONVERT(VARCHAR(10),GETDATE(), 110));

--Vogelsoort
--date format YYYY-MM-DD
INSERT INTO Vogelsoort (ID, Naam, Afkorting, BroedStart, BroedEind, BroedpaarCijfer)
						VALUES(1, 'Appelvink', 'AV',  '2017-3-15',  '2017-6-20', 3);
INSERT INTO Vogelsoort (ID, Naam, Afkorting, BroedStart, BroedEind, BroedpaarCijfer)
						VALUES(2, 'Blauwe Reiger', 'BLR', '2017-4-15', '2017-5-10', 5);
INSERT INTO Vogelsoort (ID, Naam, Afkorting, BroedStart, BroedEind, BroedpaarCijfer)
						VALUES(3, 'Boomklever', 'BKL', '2017-2-5', '2017-5-31', 5);
INSERT INTO Vogelsoort (ID, Naam, Afkorting, BroedStart, BroedEind, BroedpaarCijfer)
						VALUES(4, 'Bosrietzanger', 'B', '2017-5-15', '2017-7-20', 5);
INSERT INTO Vogelsoort (ID, Naam, Afkorting, BroedStart, BroedEind, BroedpaarCijfer)
						VALUES(5, 'Braamsluiper', 'BS', '2017-5-1', '2017-6-30', 5);

--Waarneming
INSERT INTO Waarneming(ID, Vogel_ID, Categorie, Afkorting, Punten)
					   VALUES(1, 2, 'Territorium Indicerend', 'TI', 2);
INSERT INTO Waarneming(ID, Vogel_ID, Categorie, Afkorting, Punten)
					   VALUES(2, 1, 'Vogel Aanwezig', 'VA', 1);
INSERT INTO Waarneming(ID, Vogel_ID, Categorie, Afkorting, Punten)
					   VALUES(3, 3, 'Nest Indicerend', 'NI', 3);

--Project_Bezoek
INSERT INTO Project_Bezoek(Project_ID, Bezoek_ID)
						   VALUES(1, 1);
INSERT INTO Project_Bezoek(Project_ID, Bezoek_ID)
						   VALUES(1, 2);
INSERT INTO Project_Bezoek(Project_ID, Bezoek_ID)
						   VALUES(1, 3);

--Bezoek_Waarneming
INSERT INTO Bezoek_Waarneming(Bezoek_ID, Waarneming_ID)
							  VALUES(1, 1);
INSERT INTO Bezoek_Waarneming(Bezoek_ID, Waarneming_ID)
							  VALUES(2, 2);
INSERT INTO Bezoek_Waarneming(Bezoek_ID, Waarneming_ID)
							  VALUES(3, 3);