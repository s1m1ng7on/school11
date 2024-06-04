CREATE DATABASE Geo;

--А)
CREATE TABLE Mountains(
	Id INT IDENTITY,
	MountainName NVARCHAR(20) NOT NULL,
	CountryCode VARCHAR(3) NOT NULL CHECK (LEN(CountryCode) = 3),
	Country NVARCHAR(20),
	PRIMARY KEY(Id)
);

--Б)
CREATE TABLE Peaks(
	Id INT IDENTITY,
	PeakName NVARCHAR(20) NOT NULL,
	Elevation INT NOT NULL CHECK (Elevation > 0),
	MountainId INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY(MountainId) REFERENCES Mountains(Id)
);

--В)
INSERT INTO Mountains (MountainName, CountryCode, Country) VALUES
('Рила', 'BUL', 'България'),
('Пирин', 'BUL', 'България'),
('Стара планина', 'BUL', 'България'),
('Анди', 'ARG', 'Аржентина'),
('Анди', 'CHL', 'Чили'),
('Хималаи', 'NPL', 'Непал'),
('Алпи', 'SUI', 'Швейцария'),
('Алпи', 'ITA', 'Италия'),
('Алпи', 'AUT', 'Австрия'),
('Алпи', 'FRA', 'Франция'),
('Елбрус', 'RUS', 'Русия'),
('Елбрус', 'GEO', 'Грузия');

--Г)
INSERT INTO Peaks (PeakName, Elevation, MountainId) VALUES
('Аконкагуа', 6962, 4),
('Ботев', 2376, 3),
('Мусала', 2925, 1),
('Еверест', 8849, 6),
('Вихрен', 2914, 2),
('Мальовица', 2729, 1),
('Монблан', 4809, 10),
('Матерхорн', 4478, 8),
('Дюфур', 4634, 7),
('Елбрус', 5642, 11),
('Ком', 2015, 3),
('Манаслу', 2729, 6),
('Дено', 2790, 1);

--Д)
UPDATE Peaks
SET Elevation = 2016
WHERE PeakName = 'Ком';

--Е)
SELECT AVG(SELECT Elevation FROM Peaks WHERE MountainId = 1);