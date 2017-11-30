DROP TABLE Receipt
DROP TABLE [Order]
DROP TABLE Account
DROP TABLE Drink
DROP TABLE Salad
DROP TABLE Ingredient
DROP TABLE Pizza_Ingredient
DROP TABLE Product
DROP TABLE Pizza

CREATE TABLE Pizza(
ID int PRIMARY KEY,
Name varchar(30) NOT NULL,
CrustSize varchar(20) NOT NULL,
CrustShape varchar(8) NOT NULL,
CrustType varchar(10) NOT NULL,
PurchasePrice float NOT NULL,
SellingPrice float NOT NULL
);

CREATE TABLE Product(
ID int PRIMARY KEY,
Name varchar(20) NOT NULL,
PurchasePrice float NOT NULL,
SellingPrice float NOT NULL
);

CREATE TABLE Pizza_Ingredient(
Pizza_ID int FOREIGN KEY REFERENCES Pizza(ID) NOT NULL,
Ingredient_ID int FOREIGN KEY REFERENCES Product(ID) NOT NULL
);

CREATE TABLE Ingredient(
Product_ID int FOREIGN KEY REFERENCES Product(ID),
SecondIngredient int
);

CREATE TABLE Salad(
Product_ID int FOREIGN KEY REFERENCES Product(ID),
SaladType varchar(5) NOT NULL
);

CREATE TABLE Drink(
Product_ID int FOREIGN KEY REFERENCES Product(ID),
Alcohol bit NOT NULL
);

CREATE TABLE Account(
ID int PRIMARY KEY,
Username varchar(20) NOT NULL,
Password varchar(16) NOT NULL,
AccountType varchar(10)
);

CREATE TABLE [Order](
ID int PRIMARY KEY,
User_ID int REFERENCES Account(ID) NOT NULL,
OrderDate date NOT NULL
);

CREATE TABLE Receipt(
ID int PRIMARY KEY,
Order_ID int FOREIGN KEY REFERENCES [Order](ID) NOT NULL,
ItemName varchar(20) NOT NULL,
Amount int NOT NULL,
Price float NOT NULL
);