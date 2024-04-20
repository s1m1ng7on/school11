using System;
using System.Data.SqlClient;

namespace Task1
{
    public class Program
    {
        public const string connectionString = "Data Source=GUNEVI-LAPTOP\\SQLEXPRESS;Initial Catalog=firm;Integrated Security=True";

        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Console.WriteLine("Getting all Employees...");
                SqlCommand command1 = new SqlCommand("SELECT * FROM employees", connection);
                PrintEmployees(command1);

                Console.WriteLine("Getting all Production Supervisors...");
                SqlCommand command2 = new SqlCommand("SELECT * FROM employees WHERE job_title = 'Production Supervisor'", connection);
                PrintEmployees(command2);

                Console.WriteLine("Getting all Employees with salary over $20000...");
                SqlCommand command3 = new SqlCommand("SELECT * FROM employees WHERE salary > 20000", connection);
                PrintEmployees(command3);

                Console.WriteLine("Getting all Employees from Production Department");
                SqlCommand command4 = new SqlCommand("SELECT * FROM employees WHERE department_id=7", connection);
                PrintEmployees(command4);

                Console.WriteLine("Getting all Employees working on a project starting with 'Road'");
                SqlCommand command5 = new SqlCommand("SELECT * FROM employees WHERE employee_id IN (SELECT employee_id FROM employees_projects WHERE project_id IN (SELECT project_id FROM projects AS p WHERE p.name LIKE 'Road%'))", connection);
                PrintEmployees(command5);
            }
        }

        static void PrintEmployees(SqlCommand command)
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["first_name"]} {reader["last_name"]}: {reader["salary"]}");
                }
            }
        }
    }
}