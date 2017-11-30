--drop tables
DROP TABLE Gerecht_Ingrediënt
DROP TABLE Lijst
DROP TABLE Supermarkt
DROP TABLE Gerecht
DROP TABLE Product
DROP TABLE Categorie

--create tables
CREATE TABLE Categorie(
ID int PRIMARY KEY,
HoofdCategorie_ID int FOREIGN KEY REFERENCES Categorie(ID),
Naam varchar(20) NOT NULL
);

CREATE TABLE Product(
ID int PRIMARY KEY,
Naam varchar(20) NOT NULL,
Hoeveelheid varchar(50)
);

CREATE TABLE Gerecht(
ID int PRIMARY KEY,
Naam varchar(20) NOT NULL,
);

CREATE TABLE Supermarkt(
ID int PRIMARY KEY,
Naam varchar(50) NOT NULL
);

CREATE TABLE Lijst(
ID int PRIMARY KEY,
Product_ID int FOREIGN KEY REFERENCES Product(ID) NOT NULL,
Aantal int NOT NULL
);

CREATE TABLE Gerecht_Ingrediënt(
Gerecht_ID int FOREIGN KEY REFERENCES Gerecht(ID) NOT NULL,
Product_ID int FOREIGN KEY REFERENCES Product(ID) NOT NULL,
Verpakking float
);

--Inserts
--Categorie
INSERT INTO Categorie(ID, HoofdCategorie_ID, Naam)
VALUES(1, null, 'Vleeswaren');
INSERT INTO Categorie(ID, HoofdCategorie_ID, Naam)
VALUES(2, null, 'Fruit');
INSERT INTO Categorie(ID, HoofdCategorie_ID, Naam)
VALUES(3, null, 'Groenten');

--Product
INSERT INTO Product(ID, Naam, Hoeveelheid)
VALUES(1,'Eieren', '10 stuks')
INSERT INTO Product(ID, Naam, Hoeveelheid)
VALUES(2,'Melk', '1 pak')
INSERT INTO Product(ID, Naam, Hoeveelheid)
VALUES(3,'Bloem', '300 gram')

--Gerecht
INSERT INTO Gerecht(ID, Naam)
VALUES(1, 'Pannekoeken');
INSERT INTO Gerecht(ID, Naam)
VALUES(2, 'Cake');
INSERT INTO Gerecht(ID, Naam)
VALUES(3, 'Cupcakes');

--Supermarkt
INSERT INTO Supermarkt(ID, Naam)
VALUES(1, 'Albert Heijn');
INSERT INTO Supermarkt(ID, Naam)
VALUES(2, 'Lidl');
INSERT INTO Supermarkt(ID, Naam)
VALUES(3, 'Plus');

--Lijst
INSERT INTO Lijst(ID, Product_ID, Aantal)
VALUES(1, 1, 2);
INSERT INTO Lijst(ID, Product_ID, Aantal)
VALUES(2, 2, 4);
INSERT INTO Lijst(ID, Product_ID, Aantal)
VALUES(3, 3, 3);

--Gerecht_Ingrediënt
--pannekoek
INSERT INTO Gerecht_Ingrediënt(Gerecht_ID, Product_ID, Verpakking)
VALUES(1, 1, 0.00);
INSERT INTO Gerecht_Ingrediënt(Gerecht_ID, Product_ID, Verpakking)
VALUES(1, 2, 0.00);
INSERT INTO Gerecht_Ingrediënt(Gerecht_ID, Product_ID, Verpakking)
VALUES(1, 3, 0.00);
--cake
INSERT INTO Gerecht_Ingrediënt(Gerecht_ID, Product_ID, Verpakking)
VALUES(2, 1, 0.00);
INSERT INTO Gerecht_Ingrediënt(Gerecht_ID, Product_ID, Verpakking)
VALUES(2, 2, 0.00);
INSERT INTO Gerecht_Ingrediënt(Gerecht_ID, Product_ID, Verpakking)
VALUES(2, 3, 0.00);
--cupcakes
INSERT INTO Gerecht_Ingrediënt(Gerecht_ID, Product_ID, Verpakking)
VALUES(3, 1, 0.00);
INSERT INTO Gerecht_Ingrediënt(Gerecht_ID, Product_ID, Verpakking)
VALUES(3, 2, 0.00);
INSERT INTO Gerecht_Ingrediënt(Gerecht_ID, Product_ID, Verpakking)
VALUES(3, 3, 0.00);


--queries
--get all producten voor één gerecht
SELECT *  
FROM Gerecht_Ingrediënt 
WHERE Gerecht_ID = 1;
