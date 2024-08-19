using _39.Abstract;
using _39.Enttities;
using _39.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ListCommand = "list";
            const string AddCommand = "add";
            const string DeleteCommand = "delete";
            const string GetCommand = "get";
            const string UpdateCommand = "update";
            const string ExitCommand = "exit";

            const string connectionString = "Data Source=.;Initial Catalog=programming011;Integrated Security = True";

            IAccountRepository repository = new SqlAccountRepository(connectionString);

            PrintColor("Welcome to account manager app!", ConsoleColor.Green);

            Console.WriteLine("Please enter one of the below commands");
            Console.WriteLine("- " + ListCommand);
            Console.WriteLine("- " + AddCommand);
            Console.WriteLine("- " + DeleteCommand);
            Console.WriteLine("- " + GetCommand);
            Console.WriteLine("- " + UpdateCommand);
            Console.WriteLine("- " + ExitCommand);

            while (true)
            {
                Console.Write("command: ");
                string command = Console.ReadLine();

                if (command == ExitCommand)
                {
                    break;
                }

                switch (command)
                {
                    case ListCommand:
                        ListCmd(repository); break;

                    case GetCommand:
                        Get(repository); break;
                    case DeleteCommand:
                        Delete(repository); break;
                    case AddCommand:
                        Add(repository); break;
                    case UpdateCommand:
                        Update(repository); break;
                    default:
                        PrintColor("The command is not defined in this application. Please enter one of the above valid commands", ConsoleColor.Red);
                        break;
                }
            }

            PrintColor("See you Later!", ConsoleColor.Blue);
        }

        static void ListCmd(IAccountRepository repository)
        {
            List<Account> accounts = repository.Get();

            Console.WriteLine("Id\tFirstname\tLastname");
            foreach (Account account in accounts)
            {
                PrintAacountInfoSmall(account);
            }
        }

        static void Get(IAccountRepository repository)
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Account account = repository.Get(id);

            if (account == null)
            {
                PrintColor("No account found.", ConsoleColor.Red);
                return;
            }

            PrintAccountInfoFull(account);
        }

        static void Add(IAccountRepository repository)
        {
            Account account = new Account();

            Console.Write("Firstname: ");
            account.Firstname = Console.ReadLine();

            Console.Write("Lastname: ");
            account.Lastname = Console.ReadLine();

            Console.Write("Balance: ");
            account.Balance = decimal.Parse(Console.ReadLine());

            account.LastAutoIncreaseDate = DateTime.Now;

            repository.Add(account);

            PrintColor($"Account added with id {account.Id}", ConsoleColor.Green);
        }


        static void Update(IAccountRepository repository)
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Account account = repository.Get(id);
            if (account == null)
            {
                PrintColor($"Account with id {id} do not exists.", ConsoleColor.Red);
                return;
            }

            Console.Write($"Firstname({account.Firstname}): ");
            string firstname = Console.ReadLine();

            if (string.IsNullOrEmpty(firstname) == false)
            {
                account.Firstname = firstname;
            }

            Console.Write($"Lastname({account.Lastname}): ");
            string lastname = Console.ReadLine();

            if (string.IsNullOrEmpty(lastname) == false)
            {
                account.Lastname = lastname;
            }

            Console.Write($"Balance({account.Balance}): ");
            string balance = Console.ReadLine();

            if(string.IsNullOrEmpty(balance) == false)
            {
                account.Balance = decimal.Parse(balance);
            }

            account.LastAutoIncreaseDate = DateTime.Now;

            repository.Update(account);
            PrintColor($"Account updated.", ConsoleColor.Green);
        }

        static void Delete(IAccountRepository repository)
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            repository.Delete(id);

            PrintColor("Account deleted.", ConsoleColor.Green);
        }

        static void PrintAacountInfoSmall(Account account)
        {
            Console.WriteLine($"{account.Id}\t{account.Firstname.PadRight(10)}\t{account.Lastname.PadRight(10)}");
        }

        static void PrintAccountInfoFull(Account account)
        {
            Console.WriteLine($"Id:                   {account.Id}");
            Console.WriteLine($"Firstname:            {account.Firstname}");
            Console.WriteLine($"Lastname:             {account.Lastname}");
            Console.WriteLine($"Balance:              {account.Balance}");
            Console.WriteLine($"LastAutoIncreaseDate: {account.LastAutoIncreaseDate:yyy-MM-dd HH:mm}");
        }

        static void PrintColor(string msg, ConsoleColor color)
        {
            ConsoleColor currentColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            Console.WriteLine(msg);

            Console.ForegroundColor = currentColor;
        }
    }
}
