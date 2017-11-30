--Drop tables
DROP TABLE Contract_Water
DROP TABLE ContractRegel
DROP TABLE Water
DROP TABLE Spierkrachtgedrevenboot
DROP TABLE Motorboot
DROP TABLE ExtraArtiekel
DROP TABLE Boot
DROP TABLE Artiekel
DROP TABLE Huurcontract
DROP TABLE Huurder

--Create tables
CREATE TABLE Huurder (
  ID int PRIMARY KEY,
  Naam varchar(40),
  Email varchar(80),
  Budget decimal
);

CREATE TABLE Huurcontract (
  ID int PRIMARY KEY,
  Huurder_ID int FOREIGN KEY REFERENCES Huurder(ID),
  VanDatum date,
  TotDatum date,
);

CREATE TABLE Artiekel (
  ID int PRIMARY KEY,
  Naam varchar(40),
  Huurprijs decimal
);

CREATE TABLE Boot(
  ID int PRIMARY KEY,
  Artiekel_ID int FOREIGN KEY REFERENCES Artiekel(ID),
  Registratienummer int
);

CREATE TABLE ExtraArtiekel (
  ID int PRIMARY KEY,
  Artiekel_ID int FOREIGN KEY REFERENCES Artiekel(ID)
);

CREATE TABLE Motorboot(
  ID int PRIMARY KEY,
  Boot_ID int FOREIGN KEY REFERENCES Boot(ID),
  Tankinhoud int,
  Actieradius int
);

CREATE TABLE Spierkrachtgedrevenboot(
  ID int PRIMARY KEY,
  Boot_ID int FOREIGN KEY REFERENCES Boot(ID)
);

CREATE TABLE Water(
  ID int PRIMARY KEY,
  Naam varchar(20),
  Huurprijs decimal,
  Sluisgeld decimal
);

CREATE TABLE ContractRegel(
  ID int PRIMARY KEY,
  Huurcontract_ID int FOREIGN KEY REFERENCES Huurcontract(ID),
  Artiekel_ID int FOREIGN KEY REFERENCES Artiekel(ID),
  Artiekel_Aantal int
);

CREATE TABLE Contract_Water(
  ID int PRIMARY KEY,
  Huurcontract_ID int FOREIGN KEY REFERENCES Huurcontract(ID),
  Water_ID int FOREIGN KEY REFERENCES Water(ID)
);

--Inserts 
--Huurder
INSERT INTO Huurder(ID, Naam, Email, Budget)
VALUES(1, 'Piet', 'Piet@hotmail.com', 0);

--Huurcontract
INSERT INTO Huurcontract(ID, Huurder_ID, VanDatum, TotDatum)
VALUES(1, 1, GETDATE(), GETDATE() +1);

--Artiekel
INSERT INTO Artiekel(ID, Naam, Huurprijs)
VALUES(1, 'Kano', 10.00);
INSERT INTO Artiekel(ID, Naam, Huurprijs)
VALUES(2, 'Valk zeilboot', 10.00);
INSERT INTO Artiekel(ID, Naam, Huurprijs)
VALUES(3, 'Laser zeilboot', 10.00 );
INSERT INTO Artiekel(ID, Naam, Huurprijs)
VALUES(4, 'Kruiser motorboot', 15.00);
INSERT INTO Artiekel(ID, Naam, Huurprijs)
VALUES(5, 'Zwemvest', 1.25);

--Boot
INSERT INTO Boot(ID, Artiekel_ID, Registratienummer)
VALUES(1, 1, 5342);
INSERT INTO Boot(ID, Artiekel_ID, Registratienummer)
VALUES(2, 2, 0976);
INSERT INTO Boot(ID, Artiekel_ID, Registratienummer)
VALUES(3, 3, 590430);
INSERT INTO Boot(ID, Artiekel_ID, Registratienummer)
VALUES(4, 4, 58585852);

--ExtraArtiekel
INSERT INTO ExtraArtiekel(ID, Artiekel_ID)
VALUES(1, 5);

--Motorboot
INSERT INTO Motorboot(ID, Boot_ID, Tankinhoud, Actieradius)
VALUES(1, 4, 20, 0);

--Spierkrachtgedrevenboot
INSERT INTO Spierkrachtgedrevenboot(ID, Boot_ID)
VALUES(1, 1);
INSERT INTO Spierkrachtgedrevenboot(ID, Boot_ID)
VALUES(2, 2);
INSERT INTO Spierkrachtgedrevenboot(ID, Boot_ID)
VALUES(3, 3);

--Water
INSERT INTO Water(ID, Naam, Huurprijs, Sluisgeld)
VALUES(1, 'Noordzee', 3, 1);
INSERT INTO Water(ID, Naam, Huurprijs, Sluisgeld)
VALUES(2, 'IJsselmeer', 3, 1);
INSERT INTO Water(ID, Naam, Huurprijs, Sluisgeld)
VALUES(3, 'Meereen', 1, 0.5);
INSERT INTO Water(ID, Naam, Huurprijs, Sluisgeld)
VALUES(4, 'Meertween', 1, 0.5);
INSERT INTO Water(ID, Naam, Huurprijs, Sluisgeld)
VALUES(5, 'Meerdrieen', 1, 0.5);

--ContractRegel
INSERT INTO ContractRegel(ID, Huurcontract_ID, Artiekel_ID, Artiekel_Aantal)
VALUES(1, 1, 5, 2);
INSERT INTO ContractRegel(ID, Huurcontract_ID, Artiekel_ID, Artiekel_Aantal)
VALUES(2, 1, 2, 1);

--Contract_Water
INSERT INTO Contract_Water(ID, Huurcontract_ID, Water_ID)
VALUES(1, 1, 5);

--SELECT tests
--SELECT * FROM Artiekel a
--INNER JOIN ExtraArtiekel ea ON a.ID = ea.Artiekel_ID;

--SELECT * FROM Artiekel a
--INNER JOIN Boot b ON a.ID = b.Artiekel_ID
--INNER JOIN Motorboot mb ON b.ID = mb.Boot_ID; 