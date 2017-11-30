-- Hein, eigenaar van het autoverhuurbedrijf Pak 'n Wrak, wil af van de eigen gemaakte Excel-sheets in zijn administratie. Daar worden veel te veel fouten in gemaakt. Het bijwerken van gegevens is een omslachtig proces. Om deze reden heeft hij een kennis van hem, die bekend is met het ontwerpen en opzetten van databases, een nieuw voorstel laten uitwerken.
-- Pak 'n Wrak verhuurt allerlei verschillende type voertuigen. Denk aan gewone personenauto's met en zonder trekhaak, limousines, busjes en vrachtauto's. Een huurder gaat een huurovereenkomst aan. Daarop wordt het voertuig geregistreerd dat gehuurd gaat worden. Tevens kunnen er andere huurobjecten aan de huurovereenkomst worden toegevoegd. Dit zijn zaken als een navigatiesysteem of een aanhangwagen. Voor sommige huurobjecten zijn andere huurobjecten benodigd. Zo heb je een USB-lader nodig bij je navigatiesysteem en koelbox en is een veiligheidsset vereist, met daarin onder andere een extra gevarendriehoek, bij het huren van een aanhangwagen.  Elk huurobject, ook de extra benodigdheden staan los op de huurovereenkomst!

-- Versie 1

DROP TABLE Extra;
DROP TABLE Huurobject;
DROP TABLE Huurovereenkomst;
DROP TABLE Huurder;
DROP TABLE Adres;
DROP TABLE Voertuig;
DROP TABLE Voertuigtype;

CREATE TABLE Voertuigtype (
  ID int PRIMARY KEY IDENTITY,
  Omschrijving nvarchar(100) NOT NULL,
  MaxGewicht int NOT NULL,
  PrijsPerDag decimal(6,2) NOT NULL,
  MetTrekhaak bit NOT NULL
);

INSERT INTO Voertuigtype VALUES ('Personenauto',   35000, 149.5, 0);
INSERT INTO Voertuigtype VALUES ('Personenauto+',  35000, 169.5, 1);
INSERT INTO Voertuigtype VALUES ('Limousine',      50000, 519.0, 0);
INSERT INTO Voertuigtype VALUES ('Busje',          50000, 320.0, 0);
INSERT INTO Voertuigtype VALUES ('Vrachtwagen',   100000, 999.0, 1);
INSERT INTO Voertuigtype VALUES ('Motorboot',      90000, 800.0, 0);

CREATE TABLE Voertuig (
  ID int PRIMARY KEY IDENTITY,
  VoertuigtypeID int NOT NULL REFERENCES Voertuigtype(ID),
  Kenteken nvarchar(10) UNIQUE NOT NULL
);

INSERT INTO Voertuig VALUES (1, '6-PTG-50');
INSERT INTO Voertuig VALUES (1, '2-TGG-45');
INSERT INTO Voertuig VALUES (1, '5-XTY-16');
INSERT INTO Voertuig VALUES (1, '5-SSU-82');
INSERT INTO Voertuig VALUES (1, '1-QWY-99');
INSERT INTO Voertuig VALUES (1, '9-MNK-47');
INSERT INTO Voertuig VALUES (2, '8-YIK-23');
INSERT INTO Voertuig VALUES (2, '8-OPP-26');
INSERT INTO Voertuig VALUES (2, '7-OOL-17');
INSERT INTO Voertuig VALUES (2, '9-JIH-12');
INSERT INTO Voertuig VALUES (2, '3-HJH-68');
INSERT INTO Voertuig VALUES (2, '3-KMA-67');
INSERT INTO Voertuig VALUES (3, '1-BSS-66');
INSERT INTO Voertuig VALUES (3, '9-BTC-19');
INSERT INTO Voertuig VALUES (3, '8-MAN-75');
INSERT INTO Voertuig VALUES (3, '7-UYQ-98');
INSERT INTO Voertuig VALUES (4, '4-MAP-47');
INSERT INTO Voertuig VALUES (4, '3-XSA-73');
INSERT INTO Voertuig VALUES (5, '1-TBH-16');
INSERT INTO Voertuig VALUES (5, '0-MKQ-79');
INSERT INTO Voertuig VALUES (5, '4-PZB-06');
INSERT INTO Voertuig VALUES (5, '0-IUW-81');

CREATE TABLE Adres (
  ID int PRIMARY KEY IDENTITY,
  Postcode nvarchar(8) NOT NULL,
  Huisnummer int NOT NULL,
  Woonplaats nvarchar(50) NOT NULL
);

INSERT INTO Adres VALUES ('5611AA',  16, 'Eindhoven');
INSERT INTO Adres VALUES ('5628ER',  68, 'Eindhoven');
INSERT INTO Adres VALUES ('5618KZ',   2, 'Eindhoven');
INSERT INTO Adres VALUES ('5216ER',   3, 'Den Bosch');
INSERT INTO Adres VALUES ('5237TV', 181, 'Den Bosch');
INSERT INTO Adres VALUES ('5212UA',  56, 'Den Bosch');
INSERT INTO Adres VALUES ('5229FA',  54, 'Den Bosch');
INSERT INTO Adres VALUES ('1071JA',   1, 'Amsterdam');

CREATE TABLE Huurder (
  Relatienummer int PRIMARY KEY,
  AdresID int NOT NULL REFERENCES Adres(ID),
  Naam nvarchar(50) NOT NULL,
  Voornaam nvarchar(50),
  Email nvarchar(50) NOT NULL
);

INSERT INTO Huurder (Relatienummer, AdresID, Naam, Voornaam, Email) VALUES (123456789, 1, 'van Breugelen', 'Beppie', 'beppie@vanbreugelen.nl');
INSERT INTO Huurder (Relatienummer, AdresID, Naam, Voornaam, Email) VALUES (456789123, 2, 'Traffelen', 'Truus', 'truus@traffelen.nl');
INSERT INTO Huurder (Relatienummer, AdresID, Naam, Voornaam, Email) VALUES (987456987, 2, 'Traffelen', 'Tinus', 'tinus@traffelen.nl');
INSERT INTO Huurder (Relatienummer, AdresID, Naam, Voornaam, Email) VALUES (789123456, 3, 'Pianostemmer', 'Piet', 'piet@pianostemmer.nl');
INSERT INTO Huurder (Relatienummer, AdresID, Naam, Voornaam, Email) VALUES (156987456, 5, 'der Kastelen', 'Klara', 'klara@derkastelen.nl');
INSERT INTO Huurder (Relatienummer, AdresID, Naam, Voornaam, Email) VALUES (456987123, 6, 'Koteren', 'Kees', 'kees@koteren.nl');
INSERT INTO Huurder (Relatienummer, AdresID, Naam, Voornaam, Email) VALUES (654897321, 7, 'van Jufferen', 'Jan-Dirk', 'jan-dirk@vanjufferen.nl');
INSERT INTO Huurder (Relatienummer, AdresID, Naam, Voornaam, Email) VALUES (978526156, 8, 'der Fantastique', 'Francien', 'francien@derfantastique.nl');

CREATE TABLE Huurovereenkomst (
  Factuurnummer int PRIMARY KEY,
  HuurderRelatienummer int NOT NULL REFERENCES Huurder(Relatienummer),
  VoertuigID int NOT NULL REFERENCES Voertuig(ID),
  VanDatum date NOT NULL,
  TotDatum date NOT NULL
);

INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (738642, 123456789,  1, CURRENT_TIMESTAMP -  9, CURRENT_TIMESTAMP -  7);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (124588, 123456789,  2, CURRENT_TIMESTAMP -  3, CURRENT_TIMESTAMP -  1);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (197646, 123456789,  1, CURRENT_TIMESTAMP +  1, CURRENT_TIMESTAMP +  7);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (976184, 123456789,  7, CURRENT_TIMESTAMP + 10, CURRENT_TIMESTAMP + 20);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (876019, 456789123,  3, CURRENT_TIMESTAMP + 22, CURRENT_TIMESTAMP + 22);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (197865, 456789123,  8, CURRENT_TIMESTAMP + 23, CURRENT_TIMESTAMP + 28);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (784569, 987456987,  3, CURRENT_TIMESTAMP - 13, CURRENT_TIMESTAMP - 11);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (231457, 789123456, 12, CURRENT_TIMESTAMP - 21, CURRENT_TIMESTAMP - 19);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (713956, 789123456, 13, CURRENT_TIMESTAMP - 18, CURRENT_TIMESTAMP -  5);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (124595, 789123456, 12, CURRENT_TIMESTAMP -  1, CURRENT_TIMESTAMP +  3);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (200189, 156987456, 20, CURRENT_TIMESTAMP,      CURRENT_TIMESTAMP + 31);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (809785, 156987456, 21, CURRENT_TIMESTAMP + 15, CURRENT_TIMESTAMP + 31);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (106874, 156987456, 20, CURRENT_TIMESTAMP + 32, CURRENT_TIMESTAMP + 59);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (548761, 156987456, 22, CURRENT_TIMESTAMP + 18, CURRENT_TIMESTAMP + 22);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (564781, 456987123, 16, CURRENT_TIMESTAMP +  1, CURRENT_TIMESTAMP +  9);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (849763, 456987123, 17, CURRENT_TIMESTAMP +  2, CURRENT_TIMESTAMP + 18);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (878722, 456987123, 16, CURRENT_TIMESTAMP + 11, CURRENT_TIMESTAMP + 13);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (100203, 654897321,  1, CURRENT_TIMESTAMP -  3, CURRENT_TIMESTAMP);
INSERT INTO Huurovereenkomst (Factuurnummer, HuurderRelatienummer, VoertuigID, VanDatum, TotDatum) VALUES (875104, 978526156,  5, CURRENT_TIMESTAMP -  1, CURRENT_TIMESTAMP);

CREATE TABLE Huurobject (
  ID int PRIMARY KEY IDENTITY,
  Omschrijving nvarchar(100) NOT NULL UNIQUE,
  PrijsPerDag decimal(5,2) NOT NULL,
  HuurobjectID_Benodigd int REFERENCES Huurobject(ID)
);

INSERT INTO Huurobject VALUES ('USB-lader',              1.2,  NULL);
INSERT INTO Huurobject VALUES ('Koelbox',                4.95,    1);
INSERT INTO Huurobject VALUES ('Navigatiesysteem',      29.25,    1);
INSERT INTO Huurobject VALUES ('Steekwagen',            15.0,  NULL);
INSERT INTO Huurobject VALUES ('Bobble head',            0.99, NULL);
INSERT INTO Huurobject VALUES ('Veiligheidsset',         1.0,  NULL);
INSERT INTO Huurobject VALUES ('Aanhangwagen',          49.5,     6);
INSERT INTO Huurobject VALUES ('Zonnebril',              2.5,     5);
INSERT INTO Huurobject VALUES ('Entertainment systeem', 10.95,    1);

CREATE TABLE Extra (
  Factuurnummer int REFERENCES Huurovereenkomst(Factuurnummer),
  HuurobjectID int REFERENCES Huurobject(ID),
  
  PRIMARY KEY(Factuurnummer, HuurobjectID)
);

INSERT INTO Extra VALUES (124588, 1);
INSERT INTO Extra VALUES (976184, 1);
INSERT INTO Extra VALUES (976184, 2);
INSERT INTO Extra VALUES (976184, 4);
INSERT INTO Extra VALUES (849763, 6);
INSERT INTO Extra VALUES (100203, 1);