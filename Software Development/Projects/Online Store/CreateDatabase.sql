CREATE DATABASE OnlineStoreSimeon;

CREATE TABLE Sellers (
	Id INT IDENTITY,
	[Name] NCHAR(50),
	Website NCHAR(50),
	Email NCHAR(50),
	PRIMARY KEY(Id)
);

CREATE TABLE Categories (
	Id INT IDENTITY,
	[Name] NCHAR(50) NOT NULL,
	PRIMARY KEY(Id)
);

CREATE TABLE Products (
	Id INT IDENTITY,
	[Name] NCHAR(50),
	[Description] NCHAR(200),
	Quantity INT,
	Price DECIMAL(18,0),
	CategoryId INT,
	SellerId INT,
	PRIMARY KEY(Id),
	FOREIGN KEY(CategoryId) REFERENCES Categories(Id),
	FOREIGN KEY(SellerId) REFERENCES Sellers(Id)
);

CREATE TABLE Customers (
	Id INT IDENTITY,
	FirstName NCHAR(20),
	LastName NCHAR(20),
	Email VARCHAR(320),
	PRIMARY KEY(Id)
);

CREATE TABLE Orders (
	Id INT IDENTITY,
	ProductId INT,
	CustomerId INT,
	[Date] DATETIME DEFAULT GETDATE(),
	PRIMARY KEY(Id),
	FOREIGN KEY(ProductId) REFERENCES Products(Id),
	FOREIGN KEY(CustomerId) REFERENCES Customers(Id)
);

INSERT INTO Sellers ([Name], Website, Email)
VALUES
('TechTrend', 'www.techtrend.com', 'info@techtrend.com'),
('FashionFusion', 'www.fashionfusion.com', 'info@fashionfusion.com'),
('GardenGalore', 'www.gardengalore.com', 'info@gardengalore.com'),
('BeautyBliss', 'www.beautybliss.com', 'info@beautybliss.com'),
('SportSpot', 'www.sportspot.com', 'info@sportspot.com'),
('NoveltyNook', 'www.noveltynook.com', 'info@noveltynook.com'),
('ToyTime', 'www.toytime.com', 'info@toytime.com'),
('AutoAvenue', 'www.autoavenue.com', 'info@autoavenue.com'),
('PetParadise', 'www.petparadise.com', 'info@petparadise.com'),
('OfficeOasis', 'www.officeoasis.com', 'info@officeoasis.com'),
('KitchenKraft', 'www.kitchenkraft.com', 'info@kitchenkraft.com'),
('ShoeShack', 'www.shoeshack.com', 'info@shoeshack.com'),
('ArtisanAlley', 'www.artisanalley.com', 'info@artisanalley.com'),
('BikeBoutique', 'www.bikeboutique.com', 'info@bikeboutique.com'),
('MusicMania', 'www.musicmania.com', 'info@musicmania.com'),
('SweetSensations', 'www.sweetsensations.com', 'info@sweetsensations.com'),
('FitnessFusion', 'www.fitnessfusion.com', 'info@fitnessfusion.com'),
('HomeHaven', 'www.homehaven.com', 'info@homehaven.com'),
('WellnessWorld', 'www.wellnessworld.com', 'info@wellnessworld.com'),
('CraftyCorner', 'www.craftycorner.com', 'info@craftycorner.com'),
('TravelTreasures', 'www.traveltreasures.com', 'info@traveltreasures.com'),
('BabyBoutique', 'www.babyboutique.com', 'info@babyboutique.com'),
('OutdoorOasis', 'www.outdooroasis.com', 'info@outdooroasis.com'),
('DIYDepot', 'www.diydepot.com', 'info@diydepot.com'),
('EcoEssentials', 'www.ecoessentials.com', 'info@ecoessentials.com'),
('BookwormBazaar', 'www.bookwormbazaar.com', 'info@bookwormbazaar.com'),
('TechSavvySolutions', 'www.techsavvysolutions.com', 'info@techsavvysolutions.com'),
('FashionForwardFinds', 'www.fashionforwardfinds.com', 'info@fashionforwardfinds.com'),
('PetPamperPalace', 'www.petpamperpalace.com', 'info@petpamperpalace.com'),
('CulinaryCraze', 'www.culinarycraze.com', 'info@culinarycraze.com');

INSERT INTO Categories ([Name])
VALUES
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

INSERT INTO Products ([Name], [Description], Quantity, Price, CategoryId, SellerId)
VALUES
('Samsung Galaxy S24 Ultra', 'The newest flagship by the South Korean giant Samsung.', 15, 1199, 1, 27),
('Smart LED TV', 'Experience brilliant colors and outstanding clarity with this Smart LED TV. Perfect for movie nights and gaming sessions.', 25, 699.99, 1, 1),
('Leather Jacket', 'Stay stylish and warm with this genuine leather jacket. Perfect for any occasion, whether casual or formal.', 30, 149.99, 2, 2),
('Outdoor Dining Set', 'Transform your backyard into an outdoor oasis with this elegant dining set. Durable and weather-resistant for year-round use.', 20, 899.99, 3, 3),
('Luxury Skincare Set', 'Indulge in luxurious skincare with this comprehensive set. Formulated with premium ingredients to nourish and rejuvenate your skin.', 15, 249.99, 4, 4),
('Trail Running Shoes', 'Conquer any terrain with these lightweight and responsive trail running shoes. Designed for maximum grip and stability.', 35, 129.99, 5, 5),
('Bestselling Novel Collection', 'Dive into captivating stories with this collection of bestselling novels. Perfect for avid readers and book enthusiasts.', 40, 79.99, 6, 6),
('Educational Building Blocks', 'Spark creativity and imagination with these educational building blocks. Designed to promote cognitive development in children.', 50, 39.99, 7, 7),
('Car Maintenance Kit', 'Keep your vehicle in top condition with this comprehensive car maintenance kit. Includes essential tools and accessories for DIY enthusiasts.', 10, 199.99, 8, 8),
('Premium Cat Food', 'Treat your feline friend to the finest gourmet cat food. Formulated with high-quality ingredients for optimal nutrition.', 20, 29.99, 9, 9),
('Executive Desk Organizer', 'Organize your workspace in style with this sleek executive desk organizer. Keep your essentials within reach for maximum productivity.', 15, 49.99, 10, 10),
('Wireless Bluetooth Earbuds', 'Experience true wireless freedom with these Bluetooth earbuds. Enjoy crystal-clear sound quality and long-lasting battery life.', 30, 79.99, 1, 11),
('Vintage Denim Jeans', 'Add a touch of retro flair to your wardrobe with these vintage denim jeans. Timeless style meets modern comfort.', 25, 89.99, 2, 12);

INSERT INTO Customers (FirstName, LastName, Email)
VALUES
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

INSERT INTO Orders (ProductId, CustomerId, [Date])
VALUES
(1, 2, '2023-02-15 10:23:45'),
(7, 5, '2023-04-29 15:42:18'),
(9, 3, '2023-06-05 08:55:30'),
(4, 6, '2023-07-18 17:29:12'),
(12, 1, '2023-08-21 09:48:59'),
(5, 4, '2023-10-02 11:37:24'),
(8, 7, '2023-11-11 14:20:45'),
(10, 2, '2023-12-25 19:03:08'),
(3, 5, '2024-01-13 22:10:36'),
(13, 3, '2024-02-09 07:58:51'),
(6, 7, '2024-03-04 16:45:19'),
(2, 4, '2024-04-01 18:37:55'),
(11, 1, '2024-01-28 10:55:27'),
(1, 6, '2024-02-23 14:22:08'),
(7, 3, '2023-03-09 05:49:34'),
(9, 5, '2023-05-11 22:16:02'),
(4, 7, '2023-06-30 09:37:19'),
(12, 2, '2023-08-08 12:44:40'),
(5, 4, '2023-09-17 18:01:59'),
(8, 1, '2023-10-25 03:30:21'),
(10, 6, '2023-11-28 21:49:47'),
(3, 3, '2024-01-02 11:17:12'),
(13, 5, '2024-02-04 14:39:35'),
(6, 7, '2024-03-07 06:06:53'),
(2, 1, '2024-04-09 19:15:17'),
(11, 4, '2024-03-12 22:37:38'),
(1, 6, '2023-02-19 07:04:59'),
(7, 2, '2023-04-02 18:26:22'),
(9, 5, '2023-06-15 09:48:43'),
(4, 1, '2023-07-24 12:57:06');