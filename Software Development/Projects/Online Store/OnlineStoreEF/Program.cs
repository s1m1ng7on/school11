using OnlineStoreEFCoreProject.Models.Entities;

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
                        sellers.ForEach(Console.WriteLine);
                        break;
                    case 3:
                        List<Customer> customers = databaseHelper.GetAll<Customer>();
                        customers.ForEach(Console.WriteLine);
                        break;
                    case 4:
                        List<Order> orders = databaseHelper.GetAll<Order>();

                        foreach (Order order in orders)
                        {
                            Console.WriteLine($"{databaseHelper.Get<Product>((int)order.ProductId).Name} purchased by {databaseHelper.Get<Customer>((int)order.CustomerId).FirstName} {databaseHelper.Get<Customer>((int)order.CustomerId).LastName} on {order.Date}");
                        }

                        break;
                    case 5:
                        Console.Write("Enter Product Id: ");
                        int productId = int.Parse(Console.ReadLine());

                        Product selectedProduct = databaseHelper.Get<Product>(productId);
                        Console.WriteLine($"{selectedProduct.Name} - {selectedProduct.Description}");

                        break;
                    /*case 6:
                        Console.WriteLine("Enter Seller Id:");
                        int sellerId = int.Parse(Console.ReadLine());

                        DataTable selectedSeller = databaseHelper.ExecuteReader($"SELECT * FROM Sellers WHERE Id = {sellerId}");
                        Helper.PrintSellers(selectedSeller);
                        break;*/
                    case 7:
                        Console.WriteLine("Enter Customer Id:");
                        int customerId = int.Parse(Console.ReadLine());

                        Customer selectedCustomer = databaseHelper.Get<Customer>(customerId);
                        Console.WriteLine(selectedCustomer);

                        break;
                    /*case 8:
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
                    case 10:
                        Console.Write("Enter name: ");
                        string newSellerName = Console.ReadLine();

                        Console.Write("Enter website: ");
                        string newSellerWebsite = Console.ReadLine();

                        Console.Write("Enter email: ");
                        string newSellerEmail = Console.ReadLine();

                        Seller newSeller = new Seller()
                        {
                            Name = newSellerName,
                            Website = newSellerWebsite,
                            Email = newSellerEmail
                        };

                        databaseHelper.Add<Seller>(newSeller);

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
                "(9)\t\tAdd a new Product\n" +
                "(10)\t\tAdd a new Seller\n" +
                "------------------------------------------------------\n" +
                "(end)\t\tClose the Application");
        }
    }
}