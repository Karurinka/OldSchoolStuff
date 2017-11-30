--Drop tables
DROP TABLE Uitslag
DROP TABLE Coalitie_Partij
DROP TABLE Coalitie
DROP TABLE Partij
DROP TABLE Verkiezing

--Create tables
CREATE TABLE Verkiezing(
ID int IDENTITY(1,1) PRIMARY KEY,
Naam varchar(40) UNIQUE NOT NULL,
Datum date UNIQUE NOT NULL
);

CREATE TABLE Partij(
ID int IDENTITY(1,1) PRIMARY KEY,
Naam varchar(40) UNIQUE NOT NULL,
Lijsttrekker varchar(60) UNIQUE NOT NULL
);

CREATE TABLE Coalitie(
ID int IDENTITY(1,1) PRIMARY KEY,
Premier varchar(60) NOT NULL
);

CREATE TABLE Coalitie_Partij(
Coalitie_ID int FOREIGN KEY REFERENCES Coalitie(ID),
Partij_ID int FOREIGN KEY REFERENCES Partij(ID)
);

CREATE TABLE Uitslag(
ID int IDENTITY(1,1) PRIMARY KEY,
Verkiezing_ID int FOREIGN KEY REFERENCES Verkiezing(ID),
Partij_ID int FOREIGN KEY REFERENCES Partij(ID),
Stemmen int NOT NULL,
Zetels int
);

--Inserts
--Verkiezing
INSERT INTO Verkiezing(Naam, Datum)
VALUES('Provinciale Staten Gelderland', GETDATE() +1);
INSERT INTO Verkiezing(Naam, Datum)
VALUES('Provinciale Staten Overijssel', GETDATE() -1);

--Partij
INSERT INTO Partij(Naam, Lijsttrekker)
VALUES('PVDA', 'Lodewijk Asscher');
INSERT INTO Partij(Naam, Lijsttrekker)
VALUES('D66', 'Alexander Pechtold');
INSERT INTO Partij(Naam, Lijsttrekker)
VALUES('SP', 'Emile Roemer');
INSERT INTO Partij(Naam, Lijsttrekker)
VALUES('VVD', 'Mark Rutte');
INSERT INTO Partij(Naam, Lijsttrekker)
VALUES('PvdD', 'Marianne Thieme');
INSERT INTO Partij(Naam, Lijsttrekker)
VALUES('CDA', 'Sybrand Buma');
INSERT INTO Partij(Naam, Lijsttrekker)
VALUES('GL', 'Jesse Klaver');

--Coalitie
INSERT INTO Coalitie(Premier)
VALUES('Piet');

--Coalitie_Partij
INSERT INTO Coalitie_Partij(Coalitie_ID, Partij_ID)
VALUES(1, 1);
INSERT INTO Coalitie_Partij(Coalitie_ID, Partij_ID)
VALUES(1, 2);
INSERT INTO Coalitie_Partij(Coalitie_ID, Partij_ID)
VALUES(1, 3);

--Uitslag verkiezing 1
INSERT INTO Uitslag(Verkiezing_ID, Partij_ID, Stemmen, Zetels)
VALUES(1, 1, 18451, 0)
INSERT INTO Uitslag(Verkiezing_ID, Partij_ID, Stemmen, Zetels)
VALUES(1, 2, 17482, 0);
INSERT INTO Uitslag(Verkiezing_ID, Partij_ID, Stemmen, Zetels)
VALUES(1, 3, 15368, 0);
--Uitslag verkiezing 2
INSERT INTO Uitslag(Verkiezing_ID, Partij_ID, Stemmen, Zetels)
VALUES(2, 6, 1363, 0)
INSERT INTO Uitslag(Verkiezing_ID, Partij_ID, Stemmen, Zetels)
VALUES(2, 5, 11203, 0)
INSERT INTO Uitslag(Verkiezing_ID, Partij_ID, Stemmen, Zetels)
VALUES(2, 4, 3562, 0)
INSERT INTO Uitslag(Verkiezing_ID, Partij_ID, Stemmen, Zetels)
VALUES(2, 3, 875, 0)

--Select statements
SELECT p.Naam, u.Stemmen
FROM Uitslag u
INNER JOIN Partij p ON u.Partij_ID = p.ID
INNER JOIN Verkiezing v ON u.Verkiezing_ID = v.ID
WHERE v.ID = 1;