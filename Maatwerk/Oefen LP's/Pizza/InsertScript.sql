--Standaard pizza's
INSERT INTO Pizza(ID, Name, CrustSize, CrustShape, CrustType, PurchasePrice, SellingPrice)
			VALUES(1, 'Magherita', '25cm', 'Rond', 'Dun', 8.14, 12.10);
INSERT INTO Pizza(ID, Name, CrustSize, CrustShape, CrustType, PurchasePrice, SellingPrice)
			VALUES(2, 'Magherita', '30cm', 'Rond', 'Dun', 11.72, 17.42)
INSERT INTO Pizza(ID, Name, CrustSize, CrustShape, CrustType, PurchasePrice, SellingPrice)
			VALUES(3, 'Calzone', '25cm', 'Rond', 'Dun', 12.73, 28.98);

--Producten
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(1, 'Dun deeg', 0.007, 0.008);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(2, 'Dik deeg', 0.105, 0.120);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(3, 'Glutenvrij deeg', 0.160, 0.200);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(4, 'Mozzarelllakaas', 0.0035, 0.007);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(5, 'Tomatensaus', 0.004, 0.006);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(6, 'Champignons', 0.006, 0.008);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(7, 'Salami', 0.0105, 0.0135);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(8, 'Ham', 0.01, 0.012);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(9, 'Ananas', 0.0095, 0.0120);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(10, 'Olijven', 0.0095, 0.0120);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(11, 'Tonijn', 0.0185, 0.0220);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(12, 'Paprika', 0.005, 0.0065);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(13, 'Basilicum', 0.005, 0.008);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(14, 'Spinazie', 0.0025, 0.006);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(15, 'Shoarma', 0.0135, 0.018);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(16, 'Kleine salade', 2, 3.5);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(17, 'Grote salade', 3, 6);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(18, 'Frisdrank', 1, 2);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(19, 'Bier', 1.25, 2.5);
INSERT INTO Product(ID, Name, PurchasePrice, SellingPrice)
			VALUES(20, 'Water', 1, 1.75);

--Ingredient
INSERT INTO Ingredient(Product_ID, SecondIngredient)
			VALUES(1, NULL);
INSERT INTO Ingredient(Product_ID, SecondIngredient)
			VALUES(2, NULL);
INSERT INTO Ingredient(Product_ID, SecondIngredient)
			VALUES(3, NULL);
INSERT INTO Ingredient(Product_ID, SecondIngredient)
			VALUES(4, NULL);
INSERT INTO Ingredient(Product_ID, SecondIngredient)
			VALUES(5, NULL);
INSERT INTO Ingredient(Product_ID, SecondIngredient)
			VALUES(6, NULL);
INSERT INTO Ingredient(Product_ID, SecondIngredient)
			VALUES(7, NULL);
INSERT INTO Ingredient(Product_ID, SecondIngredient)
			VALUES(8, NULL);
INSERT INTO Ingredient(Product_ID, SecondIngredient)
			VALUES();
