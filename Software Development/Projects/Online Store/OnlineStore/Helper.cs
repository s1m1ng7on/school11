using System.Data;

namespace OnlineStoreProject
{
    public static class Helper
    {
        public static void PrintInstructions()
        {
            Console.WriteLine("ONLINE STORE PROJECT\n" +
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

        public static void PrintProducts(DataTable products)
        {
            foreach (DataRow product in products.Rows)
                Console.WriteLine($"{product["Id"]}: {product["Name"]}\n" +
                    $"Description: {product["Description"]}\n" +
                    $"Category: {product["Category"]}\n" +
                    $"Seller: {product["Seller"]}\n" +
                    $"Quantity: {product["Quantity"]}x\n" +
                    $"Price: ${product["Price"]:f2}");
        }

        public static void PrintSellers(DataTable sellers)
        {
            foreach (DataRow seller in sellers.Rows)
                Console.WriteLine($"{seller["Id"]}: {seller["Name"]}\n" +
                    $"Email: {seller["Email"]}\n" +
                    $"Website: {seller["Website"]}");
        }

        public static void PrintCustomers(DataTable customers)
        {
            foreach (DataRow customer in customers.Rows)
                Console.WriteLine($"{customer["Id"]}: {customer["FirstName"]} {customer["LastName"]}\n" +
                    $"Email: {customer["Email"]}");
        }

        public static void PrintOrders(DataTable orders)
        {
            foreach (DataRow order in orders.Rows)
                Console.WriteLine($"{order["Id"]}: {order["CustomerFirstName"]} {order["CustomerLastName"]} purchased {order["ProductName"]}\n" +
                    $"Date: {order["Date"]}");
        }
    }
}
