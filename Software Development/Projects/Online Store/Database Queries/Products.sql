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

INSERT INTO Products ([Name], [Description], Quantity, Price, CategoryId, SellerId) VALUES
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