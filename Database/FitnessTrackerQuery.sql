CREATE TABLE Trainers (
	TrainerID VARCHAR(30) NOT NULL PRIMARY KEY,
	FullName VARCHAR(100) NOT NULL,
	Username VARCHAR(100) NOT NULL UNIQUE,
	Email VARCHAR(255) NOT NULL UNIQUE,
	Password VARCHAR(100) NOT NULL,
	DOB DATE NOT NULL,
	Gender VARCHAR(10) NOT NULL,
	Phone VARCHAR(30) NOT NULL,
	Address VARCHAR(255) NOT NULL,
	CreatedDate DATETIME DEFAULT SYSDATETIME()
);

SELECT * FROM Trainers;

CREATE TABLE Activities (
	ActID VARCHAR(30) NOT NULL PRIMARY KEY,
	ActName VARCHAR(100) NOT NULL UNIQUE,
	MetricOne VARCHAR(100),
	MetricTwo VARCHAR(100),
	MetricThree VARCHAR(100),
	CreatedDate DATETIME DEFAULT SYSDATETIME()
);

SELECT * FROM Activities;

CREATE TABLE Users (
	UserID VARCHAR(30) NOT NULL PRIMARY KEY,
	Fullname VARCHAR(100) NOT NULL,
	Username VARCHAR(100) NOT NULL UNIQUE,
	Email VARCHAR(255) NOT NULL UNIQUE,
	Password VARCHAR(100) NOT NULL,
	DOB DATE NOT NULL,
	NationalID VARCHAR(100) NOT NULL UNIQUE,
	Weight DECIMAL NOT NULL,
	Height DECIMAL NOT NULL,
	Phone VARCHAR(30) NOT NULL,
	Address VARCHAR(255) NOT NULL,
	CreatedDate DATETIME DEFAULT SYSDATETIME()
);

SELECT * FROM Users;

CREATE TABLE Tracker (
	TrackerID VARCHAR(30) NOT NULL PRIMARY KEY,
	ActID VARCHAR(30) NOT NULL,
	UserID VARCHAR(30) NOT NULL,
	TrackerName VARCHAR(100) NOT NULL,
	SetGoal INT NOT NULL,
	TotalCalBurn INT,
	TrackDate DATE NOT NULL,
	TrackStatus VARCHAR(30),
	CreatedDate DATETIME DEFAULT SYSDATETIME(),

	FOREIGN KEY (ActID) REFERENCES Activities(ActID),
	FOREIGN KEY (UserID) REFERENCES Users(UserID)
);


SELECT * FROM Tracker;

/*-----------------------------------------------------------------------------*/

/*--------------------------------Drop Tables-----------------------------------*/

DROP TABLE Trainers;
DROP TABLE Users;
DROP TABLE Activities;
DROP TABLE Tracker;

/*-----------------------------------------------------------------------------*/

/*--------------------------------Test Query-----------------------------------*/
SELECT * FROM Users;

SELECT * FROM Trainers;

DELETE FROM Trainers;

SELECT * FROM Tracker;

SELECT COUNT(*) FROM Tracker
WHERE TrackStatus IS NULL;

SELECT * FROM Activities;

SELECT Tracker.*, Activities.ActName AS ActivityName FROM Tracker
INNER JOIN Activities ON Tracker.ActID=Activities.ActID
WHERE Tracker.UserID='U0001'
AND Tracker.SetGoal=3000
ORDER BY Tracker.CreatedDate DESC;

SELECT Tracker.*, Activities.ActName AS ActivityName FROM Tracker
INNER JOIN Activities ON Tracker.ActID=Activities.ActID
WHERE Tracker.UserID='U0001'
AND Tracker.TrackerName LIKE 'test%'
ORDER BY Tracker.CreatedDate DESC;

SELECT Tracker.*, Activities.ActName AS ActivityName FROM Tracker
INNER JOIN Activities ON Tracker.ActID=Activities.ActID
WHERE Tracker.UserID='U0001'
AND Tracker.CreatedDate >= '2025-03-09 00:27:26.597' 
AND Tracker.CreatedDate <= '2025-03-09 23:28:22.487'
ORDER BY Tracker.CreatedDate DESC;

SELECT Tracker.*, Activities.ActName AS ActivityName FROM Tracker
INNER JOIN Activities ON Tracker.ActID=Activities.ActID
WHERE Tracker.UserID='U0001'
AND Tracker.TrackDate >= '2025-03-08'
AND Tracker.TrackDate <= '2025-03-19'
ORDER BY Tracker.CreatedDate DESC;

SELECT Tracker.*, Activities.ActName AS ActivityName FROM Tracker
INNER JOIN Activities ON Tracker.ActID=Activities.ActID
WHERE Tracker.UserID='U0001'
AND Tracker.TrackStatus IS NULL
ORDER BY Tracker.CreatedDate DESC;

SELECT Tracker.*, Activities.ActName AS ActivityName FROM Tracker
INNER JOIN Activities ON Tracker.ActID=Activities.ActID
WHERE Tracker.UserID='U0001'
AND Tracker.ActID='A0002'
ORDER BY Tracker.CreatedDate DESC;