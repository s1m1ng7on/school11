using System.Data;

namespace OnlineStoreProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Helper.PrintInstructions();

            //Enter your database server connection string after creating it using the CreateDatabase.sql file
            string connectionString = "...";
            DatabaseHelper databaseHelper = new DatabaseHelper(connectionString);

            string command;
            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                int commandNumber = int.Parse(command);
                switch (commandNumber)
                {
                    case 1:
                        DataTable products = databaseHelper.ExecuteReader("SELECT p.Id, p.Name, p.Description, p.Quantity, p.Price, c.Name AS Category, s.Name AS Seller FROM Products AS p JOIN Categories AS c ON p.CategoryId = c.Id JOIN Sellers AS s ON p.SellerId = s.Id");
                        Helper.PrintProducts(products);
                        break;
                    case 2:
                        DataTable sellers = databaseHelper.ExecuteReader("SELECT * FROM Sellers");
                        Helper.PrintSellers(sellers);
                        break;
                    case 3:
                        DataTable customers = databaseHelper.ExecuteReader("SELECT * FROM Customers");
                        Helper.PrintCustomers(customers);
                        break;
                    case 4:
                        DataTable orders = databaseHelper.ExecuteReader("SELECT o.Id, p.Name AS ProductName, c.FirstName AS CustomerFirstName, c.LastName AS CustomerLastName, o.Date FROM Orders AS o JOIN Products AS p ON o.ProductId = p.Id JOIN Customers AS c ON o.CustomerId = c.Id");
                        Helper.PrintOrders(orders);
                        break;
                    case 5:
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
                        break;
                }
            }
        }
    }
}