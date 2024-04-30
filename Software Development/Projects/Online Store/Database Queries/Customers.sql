CREATE TABLE Customers (
	Id INT IDENTITY,
	FirstName NCHAR(20),
	LastName NCHAR(20),
	Email VARCHAR(320),
	PRIMARY KEY(Id)
);

INSERT INTO Customers (FirstName, LastName, Email) VALUES
	('Simeon', 'Gunev', 'simganev@gmail.com'),
	('Stoika', 'Petkova', 'pettkovva.s@abv.bg'),
	('Kalina', 'Dardanelova', 'kk.linka@abv.bg'),
	('Jonathan', 'Ardern', 'jonathan@ardern.com'),
	('Ivana', 'Iliyska', 'van4eto-iliyska@mail.bg'),
	('Tihomir', 'Spirov', 'tisho.spirtista@abv.bg'),
	('Petur', 'Dimitrov', 'peter_dd@gmail.com'),
	('Hristiyan', 'Iliev', 'hristiyan_2006@abv.bg'),
	('Petka', 'Shipkova', 'shipkova1999@hotmail.com'),
	('Ruslan', 'Dragomirov', 'dragomirkata.rr@abv.bg'),
	('Miranda', 'Smith', 'smith-miranda@outlook.com');