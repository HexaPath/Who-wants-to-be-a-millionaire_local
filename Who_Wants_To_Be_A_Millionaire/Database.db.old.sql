BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `users` (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`user`	TEXT NOT NULL,
	`password`	TEXT NOT NULL
);
INSERT INTO `users` (id,user,password) VALUES (1,'test1','test1');
INSERT INTO `users` (id,user,password) VALUES (2,'test2','test2');
INSERT INTO `users` (id,user,password) VALUES (3,'singup','test4');
INSERT INTO `users` (id,user,password) VALUES (4,'singuptest1','singuptest1');
CREATE TABLE IF NOT EXISTS `game` (
	`ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`Q`	TEXT NOT NULL,
	`A`	TEXT NOT NULL,
	`B`	TEXT NOT NULL,
	`C`	TEXT NOT NULL,
	`D`	TEXT NOT NULL,
	`Ans`	INTEGER NOT NULL
);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (1,'What did Peggy Carter promise to Steve Rogers before he crashed Red Skull''s bomber?','Sex','Kiss','Date','Dance',4);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (2,'Who is Loki''s biological father?','Volstagg','Jotunn','Odin','Laufey',4);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (3,'What powers Iron Man''s suit?','Battery ','Arc Reactor','Lithium Ion Battery','The Arkstone',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (4,'Who said it : "I like your knife, I''m keeping it."','Drax','Black Widow','Steve Rogers','Rocket Raccoon',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (5,'Who played Drax the Destroyer?','Georges St. Pierre','Dave Bautista','Randy Couture','Steve Austin',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (6,'What''s Jane Foster''s profession in the Marvel Cinematic Universe?','Medical Doctor','Geologist','Physicst','Meteorolgist ',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (7,'Where did Iron Man first face off against Whiplash?','Paris','Monaco','New York','Daytona',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (8,'Who said it : "Nothing goes over my head. My reflexes are too fast. I would catch it."','Steve Rogers','Ivan Vanko','Drax','Emil Blonsky',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (9,'Orb holds which Infinity Stone?','The Space Stone','The Mind Stone','The Power Stone','The Time Stone',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (10,'Which of these characters DID NOT wear an Iron Man suit in ''Iron Man 3''?','James Rhodes','Pepper Pottss','President Ellis','Happy Hogan',4);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (11,'How many "Infinity Stones" are said to exist in the Marvel Cinematic Universe?','20','6','2','12',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (12,'Who said it : "I recognize the council has made a decision, but given that it''s a stupid-ass decision, I''ve elected to ignore it."','Nick Fury','Black Widow','Tony Stark','Alexander Pierce',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (13,'How does Yondu control his deadly hovering arrow?','By Talking To It','With A Hidden Remote','By Whistling','With His Mind Powers',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (14,'What''s Hawkeye''s real name?','Barton Carter','Clint Coulson','Clint Barton','Bart Clinton',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (15,'What''s Captain America''s shield made of?','Titanium Alloy','Mithril','Adamantium','Vibranium',4);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (16,'What was the final movie in Marvel''s "Phase I"?','Captain America : The First Avenger','The Avengers','Iron Man 3','Guardians Of The Galaxy',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (17,'By which of these other monikers is Odin known?','Beardpapa','The Allfather','The Wisefather','The Truthsayer',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (18,'Name this "mastermind" behind the Marvel Cinematic Universe.','Joss Whedon','Kevin Feige','Jon Favreau','Stan Lee',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (19,'Who said it : "I have lived most of my life surrounded by my enemies. I would be grateful to die surrounded by my friends."','Drax','Gamora','Black Widow','Loki',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (20,'What brother and sister pair from the comics were revealed in the post-credits scene for ''Captain America: The Winter Soldier''?','Sue and Johnny Storm','Andrea and Andreas Von Strucker','Quicksilver And The Scarlet Witch','Satana and Hellstorm',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (21,'Forged in the heart of a dying star, what is Thor''s hammer''s name?','Mjolnir','Thunder Bringer','Fjordir','Anduril',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (22,'In which Marvel movie did Samuel L. Jackson first appear as Nick Fury?','Iron Man 2','Thor','The Incredible Hulk','Iron Man',4);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (23,'Who said it : "If I had a blacklight, this place would look like a Jackson Pollock painting."','Star-Lord','Black Widow','Pepper Potts','Tony Stark',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (24,'What race is Ronan the Accuser?','Kree','Human','Skrull','Xandarian',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (25,'Tesseract is which Infinity Stone?','The Reality Stone','The Sould Stone','The Power Stone','The Space Stone',4);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (26,'What was Red Skull''s real name?','Arnim Zola','Johann Schmidt','Joseph Goebbels','Johannes Wagner',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (27,'What brothers co-directed ''Captain America: The Winter Soldier''?','Joel & Ethan Coen','Ted & Sam Raimi','Sean & James Gunn','Joe & Anthony Russo',4);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (28,'In ''The Avengers,'' what S.H.I.E.L.D. agent does Black Widow say first brought her into the fold?','Hawkeye','Agent Coulson','Peggy Carter','Nick Fury',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (29,'What power source fuels Tony Stark''s Iron Man suit?','Lithium Ion Battery','Arc Reactor','The Arkstone','The Tesseract',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (30,'Who directed ''The Avengers''?','Joss Whedon','James Cameron','James Gunn','David S. Goyer',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (31,'What classic video game does Tony Stark catch someone playing on the S.H.I.E.L.D. heli-carrier in ''The Avengers''?','Donkey Kong','Galaga','Pac-Man','Space Invaders',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (32,'Which infinity stone is in Tessaract?','Space Stone','Mind Stone','Reality Stone','Power Stone',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (33,'Which infinity stone is in Scepter?','Space Stone','Mind Stone','Reality Stone','Power Stone',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (34,'Which infinity stone is in Aether?','Space Stone','Mind Stone','Reality Stone','Power Stone',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (35,'Which infinity stone is in Eye of Agamotto? ','Time Stone','Sould Stone','Power Stone','Reality Stone',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (36,'What infinity stone was last revealed in Marvel Cinematic Universe ? ','Space Stone','Time Stone','Sould Stone','Power Stone',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (37,'What year was first Iron Man movie released ?','2005','2008','2010','2012',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (38,'Which movie ended Marvel Cinematic Universe''s Phase ?','Iron Man 3','Captain America : The First Avenger','Thor','Marvel''s The Avengers',4);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (39,'In which movie did Marvel Cinematic Universe presented first infinity stone?','The Incredible Hulk','Iron Man 2','Captain America: The First Avenger',' Marvel''s The Avengers',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (40,'Which marvel character''s movie hasn''t been filmed yet ?','Black Panther','Black Widow','Doctor Strange','And-Man',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (41,'How many stand-alone Iron Man films are there?','1','2','3','4',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (42,'How many stand-alone Captain America films are there?','1','2','3','4',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (43,'How many stand-alone Thor films are there?','1','2','3','4',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (44,'How many stand-alone Guardians of the Galaxy films are there?','1','2','3','4',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (45,'How many stand-alone Doctor Strange films are there?','1','2','3','4',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (46,'How many stand-alone Spider-man films are there in All new Marvel Cinematic Universe?','1','2','3','4',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (47,'How many stand-alone Black Panther films are there?','1','2','3','4',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (48,'How many stand-alone Ant-Man films are there?','1','2','3','4',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (49,'Which of these characters is not a villain','Armin Zola','Armin Zola','Mandarin','Dr. Octopus',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (50,'Who was called numerous time "a menace"','Daredevil','Wolverine','Wolverine','Iron-man',3);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (51,'What is Professor Xavier''s Telepathy enhancing-machine called?','Psychismo','Cerebro','The Cortex','The Mighty Enhancer',2);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (52,'What''s the name of the rival shrinking technology in the 2015 film, Ant Man?','Yellowjacket','Bluejacket','Bluejacket',' Blackjacket',1);
INSERT INTO `game` (ID,Q,A,B,C,D,Ans) VALUES (53,'What''s upcoming sequel to Avengers: Age of Ultron named?','Avengers: Battle of Thanos','Avengers: Battle of Thanos','Avengers: Battle of Thanos','Avengers: Space Battle',3);
COMMIT;
