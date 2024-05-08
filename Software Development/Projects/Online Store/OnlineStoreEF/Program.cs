using System;
using System.Data;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using OnlineStoreEFCoreProject.Entities;

namespace OnlineStoreEFCoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            DisplayInstructions();

            DatabaseHelper databaseHelper = new DatabaseHelper();

            string command;
            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                int commandNumber = int.Parse(command);
                switch (commandNumber)
                {
                    case 1:
                        List<Product> products = databaseHelper.GetAll<Product>();
                        
                        foreach (var product in products)
                        {
                            Console.WriteLine($"{product.Name} - {product.Description}");
                        }

                        break;
                    case 2:
                        List<Seller> sellers = databaseHelper.GetAll<Seller>();

                        foreach (Seller seller in sellers)
                        {
                            Console.WriteLine($"{seller.Name} ({seller.Website})");
                        }
                        break;
                    case 3:
                        List<Customer> customers = databaseHelper.GetAll<Customer>();

                        foreach (Customer customer in customers)
                        {
                            Console.WriteLine($"{customer.FirstName} {customer.LastName} ({customer.Email})");
                        }

                        break;
                    case 4:
                        List<Order> orders = databaseHelper.GetAll<Order>();

                        foreach (Order order in orders)
                        {
                            Console.WriteLine($"{order.Product.Name} purchased by {order.Include(i => i.Customer).FirstName} {order.Customer.LastName} on {order.Date}");
                        }

                        break;
                    /*case 5:
                        Console.WriteLine("Enter Product Id:");
                        int productId = int.Parse(Console.ReadLine());

                        DataTable selectedProduct = databaseHelper.ExecuteReader($"SELECT p.Id, p.Name, p.Description, p.Quantity, p.Price, c.Name AS Category, s.Name AS Seller FROM Products AS p JOIN Categories AS c ON p.CategoryId = c.Id JOIN Sellers AS s ON p.SellerId = s.Id WHERE p.Id = {productId}");
                        Helper.PrintProducts(selectedProduct);
                        break;
                    case 6:
                        Console.WriteLine("Enter Seller Id:");
                        int sellerId = int.Parse(Console.ReadLine());

                        DataTable selectedSeller = databaseHelper.ExecuteReader($"SELECT * FROM Sellers WHERE Id = {sellerId}");
                        Helper.PrintSellers(selectedSeller);
                        break;
                    case 7:
                        Console.WriteLine("Enter Customer Id:");
                        int customerId = int.Parse(Console.ReadLine());

                        DataTable selectedCustomer = databaseHelper.ExecuteReader($"SELECT * FROM Customers WHERE Id = {customerId}");
                        Helper.PrintCustomers(selectedCustomer);
                        break;
                    case 8:
                        Console.WriteLine("Enter Order Date in the following format (DD/MM/YYYY):");
                        string[] selectedDate = Console.ReadLine().Split('/');

                        DataTable selectedOrders = databaseHelper.ExecuteReader($"SELECT o.Id, p.Name AS ProductName, c.FirstName AS CustomerFirstName, c.LastName AS CustomerLastName, o.Date FROM Orders AS o JOIN Products AS p ON o.ProductId = p.Id JOIN Customers AS c ON o.CustomerId = c.Id WHERE Date < '{selectedDate[2]}-{selectedDate[1]}-{selectedDate[0]}'");
                        Helper.PrintOrders(selectedOrders);
                        break;*/
                    case 9:
                        Console.Write("Enter name: ");
                        string newProductName = Console.ReadLine();

                        Console.Write("Enter description: ");
                        string newProductDescription = Console.ReadLine();

                        Console.Write("Enter quantity: ");
                        int newProductQuantity = int.Parse(Console.ReadLine());

                        Console.Write("Enter price: ");
                        decimal newProductPrice = decimal.Parse(Console.ReadLine());

                        Console.Write("Enter category id: ");
                        int newProductCategoryId = int.Parse(Console.ReadLine());

                        Console.Write("Enter seller id: ");
                        int newProductSellerId = int.Parse(Console.ReadLine());

                        Product newProduct = new Product()
                        {
                            Name = newProductName,
                            Description = newProductDescription,
                            Quantity = newProductQuantity,
                            Price = newProductPrice,
                            CategoryId = newProductCategoryId,
                            SellerId = newProductSellerId
                        };

                        databaseHelper.Add<Product>(newProduct);

                        break;
                }
            }
        }

        static void DisplayInstructions()
        {
            Console.WriteLine("ONLINE STORE PROJECT\n" +
                "Reworked Using Entity Framework Core\n" +
                "By Simeon Gunev\n" +
                "\n" +
                "CODE:\t\tCOMMAND:\n" +
                "(1)\t\tPrint all Products\n" +
                "(2)\t\tPrint all Sellers\n" +
                "(3)\t\tPrint all Customers\n" +
                "(4)\t\tPrint all Orders\n" +
                "------------------------------------------------------\n" +
                "(5)\t\tSearch for a Product by Id\n" +
                "(6)\t\tSearch for a Seller by Id\n" +
                "(7)\t\tSearch for a Customer by Id\n" +
                "(8)\t\tSearch for Orders Placed Before a Date\n" +
                "------------------------------------------------------\n" +
                "(end)\t\tClose the Application");
        }

        static void AddProduct(string name, string description, int quantity, decimal price, int categoryId, int sellerId)
        {
            using (OnlineStoreSimeonContext context = new OnlineStoreSimeonContext())
            {
                Product newProduct = new Product
                {
                    Name = name,
                    Description = description,
                    Quantity = quantity,
                    Price = price,
                    CategoryId = categoryId,
                    SellerId = sellerId
                };

                context.Products.Add(newProduct);
                context.SaveChanges();
            }
        }
    }
}