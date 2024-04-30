CREATE TABLE Categories (
	Id INT IDENTITY,
	[Name] NCHAR(50) NOT NULL,
	PRIMARY KEY(Id)
);

INSERT INTO Categories ([Name]) VALUES
	('Electronics'),
	('Clothing'),
	('Home & Garden'),
	('Health & Beauty'),
	('Sports & Outdoors'),
	('Books & Media'),
	('Toys & Games'),
	('Automotive'),
	('Pet Supplies'),
	('Office Supplies');