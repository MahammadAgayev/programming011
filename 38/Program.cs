using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection.Emit;

namespace _38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //connection string

            try
            {
                //string connectionString = "Data Source=.;Initial Catalog=programming011;Integrated Security=True";
                //string connectionString = "Data Source=.;Initial Catalog=programming011;Integrated Security=False;User Id=sa;Password=testJoooyo";

                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                sb.DataSource = ".";
                sb.InitialCatalog = "programming011";
                sb.IntegratedSecurity = true;

                using (SqlConnection connection = new SqlConnection(sb.ConnectionString))
                {
                    connection.Open();
                    Info("DB connection successful.");

                    //string query = @"insert into Accounts(Firstname, Lastname, Balance, LastAutoIncreaseDate)
                    //            values('Cavad', 'Alizada', 1000, getdate())";

                    //SqlCommand cmd = new SqlCommand(query, connection);

                    //cmd.ExecuteNonQuery();

                    //string deleteQuery = @"delete from Accounts where firstname='Cavad'";
                    //SqlCommand cmd = new SqlCommand(deleteQuery, connection);

                    //cmd.ExecuteNonQuery();

                    //AddAccount(connection);
                    //DeleteAccount(connection);

                    ListAccounts(connection);
                }

                Info("Query executed.");
            }
            catch (Exception e)
            {
                Error($"db connection failed, {e.Message}");
            }
        }

        static void AddAccount(SqlConnection connection)
        {
            const string query = @"
            insert into Accounts(Firstname, Lastname, Balance, LastAutoIncreaseDate)
            values(@firstname, @lastname, @balance, @date)";

            SqlCommand cmd = new SqlCommand(query, connection);

            Console.Write("Firstname: ");
            string firstname = Console.ReadLine();

            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();

            Console.Write("Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            DateTime lastDate = DateTime.Now;

            cmd.Parameters.AddWithValue("firstname", firstname);
            cmd.Parameters.AddWithValue("lastname", lastname);
            cmd.Parameters.AddWithValue("balance", balance);
            cmd.Parameters.AddWithValue("date", lastDate);

            Console.WriteLine("press ENTER to add account");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key != ConsoleKey.Enter)
            {
                Warning("You did not press enter. Data will not be written");
                return;
            }

            cmd.ExecuteNonQuery();
        }

        static void DeleteAccount(SqlConnection connection)
        {
            const string query = "delete from Accounts where id = @id";

            SqlCommand cmd = new SqlCommand(query, connection);

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            cmd.Parameters.AddWithValue("id", id);

            Warning($"The account with id {id} will be deleted, press ENTER to continue");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key != ConsoleKey.Enter)
            {
                Warning("You did not press enter. Nothing executed!");
                return;
            }

            cmd.ExecuteNonQuery();
        }


        static void ListAccounts(SqlConnection connection)
        {
            const string query = "select  * from Accounts";

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("ID\tFirstname\tLastname\tBalance");
            while (reader.Read())
            {
                int id = (int)reader["Id"];
                string firstname = (string)reader["firstname"];
                string lastname = (string)reader["lastname"];
                decimal balance = (decimal)reader["balance"];

                Console.WriteLine($"{id}\t{firstname.PadRight(10)}\t{lastname.PadRight(10)}\t{balance:0.00}");

            }
        }

        static void Error(string message)
        {
            ConsoleColor current = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"ERROR: {message}");

            Console.ForegroundColor = current;
        }

        static void Info(string message)
        {
            ConsoleColor current = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"INFO: {message}");

            Console.ForegroundColor = current;
        }

        static void Warning(string message)
        {
            ConsoleColor current = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"WARNING: {message}");

            Console.ForegroundColor = current;
        }
    }
}
