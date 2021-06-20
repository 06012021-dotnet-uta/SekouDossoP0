CREATE DATABASE RpsGameDb;

-- CREATE SCHEMA RpsGame;

DROP TABLE Players;

CREATE TABLE Players(
	PlayerId int PRIMARY KEY NOT NULL IDENTITY(1,1) ,
	PlayerFname NVARCHAR(20) NOT NULL,
	PlayerLname NVARCHAR(20) NOT NULL,
	PlayerAge INT NULL,
	CONSTRAINT AgeUnder125 CHECK (PlayerAge < 125 AND PlayerAge > 0  )
);

INSERT INTO Players (PlayerFname, PlayerLname, PlayerAge)
VALUES ('Mark', 'Moore', 42);

INSERT INTO Players (PlayerFname, PlayerLname, PlayerAge)
VALUES ('Sekou', 'Dosso', 60);

SELECT * FROM Players;

