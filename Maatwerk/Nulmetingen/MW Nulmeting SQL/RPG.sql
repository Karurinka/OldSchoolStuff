-- Drop statements
DROP TABLE Battle;
DROP TABLE CharacterInTeam;
DROP TABLE Team;
DROP TABLE Character;
DROP TABLE Player;

-- Create statements
CREATE TABLE Player (
  email VARCHAR(100) PRIMARY KEY,
  password VARCHAR(100),
  xp INT,
  
  CHECK (email = LOWER(email)),
  CHECK (LEN(password) >= 6),
  CHECK (LEN(password) <= 16)
);

CREATE TABLE Character (
  id INT PRIMARY KEY,
  player_email VARCHAR(100) NOT NULL REFERENCES Player(email),
  name VARCHAR(100) NOT NULL,
  health INT NOT NULL,
  attack INT NOT NULL,
  defence INT NOT NULL,
  
  CHECK (health + attack + defence = 200),
  CHECK (health >= 50),
  CHECK (attack >= 50),
  CHECK (defence >= 50)
);

CREATE TABLE Team (
  name VARCHAR(100) PRIMARY KEY,
  color VARCHAR(32) NOT NULL,
  altColor VARCHAR(32) NOT NULL,
  
  CHECK (color IN ('Rood', 'Groen', 'Geel', 'Blauw', 'Zwart')),
  CHECK (altColor IN ('Rood', 'Groen', 'Geel', 'Blauw', 'Zwart')),
  CHECK (color <> altColor)
);

CREATE TABLE CharacterInTeam (
  character_id INT REFERENCES Character(id),
  team_name VARCHAR(100) REFERENCES Team(name),
  
  PRIMARY KEY (character_id, team_name)
);

CREATE TABLE Battle (
  team_name_1 VARCHAR(100) REFERENCES Team(name),
  team_name_2 VARCHAR(100) REFERENCES Team(name),
  battleDate DATE,
  bet INT NOT NULL,
  team_name_winning VARCHAR(100) REFERENCES Team(name),
  
  PRIMARY KEY (team_name_1, team_name_2, battleDate),
  CHECK (bet > 0)
);


-- Test data
Insert into TEAM (NAME,COLOR,ALTCOLOR) values ('Bashers'       ,'Rood' ,'Groen');
Insert into TEAM (NAME,COLOR,ALTCOLOR) values ('Slashers'      ,'Geel' ,'Blauw');
Insert into TEAM (NAME,COLOR,ALTCOLOR) values ('Elites'        ,'Zwart','Geel');
Insert into TEAM (NAME,COLOR,ALTCOLOR) values ('Shiny Armor'   ,'Blauw','Rood');
Insert into TEAM (NAME,COLOR,ALTCOLOR) values ('Chicken Little','Geel' ,'Rood');
Insert into TEAM (NAME,COLOR,ALTCOLOR) values ('Speeders'      ,'Zwart','Groen');

Insert into PLAYER (EMAIL,PASSWORD,XP) values ('jan@mail.nl'     ,'Geheim','100');
Insert into PLAYER (EMAIL,PASSWORD,XP) values ('piet@hotmail.com','Geheim','200');
Insert into PLAYER (EMAIL,PASSWORD,XP) values ('klaas@live.nl'   ,'Geheim',  '0');
Insert into PLAYER (EMAIL,PASSWORD,XP) values ('sara@live.nl'    ,'Geheim', '50');

Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()-14,'110','Bashers');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()-13, '50','Slashers');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()-11, '50','Slashers');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()-10, '70','Slashers');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()-9 , '60','Slashers');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()-6 ,'200','Bashers');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Elites' ,'Speeders'   ,GETDATE()-5 ,'200','Speeders');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()-5 , '75','Bashers');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()-2 ,'125','Bashers');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()-1 , '50','Slashers');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Elites' ,'Shiny Armor',GETDATE()-1 ,'250','Elites');
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()+2 , '75',null);
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Bashers','Slashers'   ,GETDATE()+4 ,'175',null);
Insert into BATTLE (team_name_1,team_name_2,BATTLEDATE,BET,TEAM_NAME_WINNING) values ('Elites' ,'Shiny Armor',GETDATE()+5 ,'250',null);

Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('1','jan@mail.nl'     ,'Paladin 1','100','50', '50');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('2','jan@mail.nl'     ,'Paladin 2', '75','75', '50');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('3','jan@mail.nl'     ,'Paladin 3', '50','50','100');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('4','piet@hotmail.com','Goblin 1' , '50','50','100');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('5','piet@hotmail.com','Goblin 2' , '60','50', '90');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('6','piet@hotmail.com','Goblin 3' , '55','65', '80');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('7','klaas@live.nl'   ,'Knight 1' , '50','50','100');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('8','klaas@live.nl'   ,'Knight 2' , '75','50', '75');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('9','klaas@live.nl'   ,'Knight 3' ,'100','50', '50');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('10','sara@live.nl'   ,'Archer 1' , '75','75', '50');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('11','sara@live.nl'   ,'Archer 2' , '50','50','100');
Insert into CHARACTER (ID,PLAYER_EMAIL,NAME,HEALTH,ATTACK,DEFENCE) values ('12','sara@live.nl'   ,'Archer 3' ,'100','50', '50');

Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '1','Bashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '2','Bashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '3','Bashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '4','Bashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '5','Bashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '6','Slashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '7','Slashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '8','Slashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '9','Slashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ('10','Slashers');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '1','Elites');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '2','Elites');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ('10','Elites');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ('11','Elites');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ('12','Elites');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '1','Shiny Armor');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '7','Shiny Armor');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '8','Shiny Armor');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ( '9','Shiny Armor');
Insert into CHARACTERINTEAM (CHARACTER_ID,TEAM_NAME) values ('10','Shiny Armor');
