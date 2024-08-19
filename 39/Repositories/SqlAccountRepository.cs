using _39.Abstract;
using _39.Enttities;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _39.Repositories
{
    public class SqlAccountRepository : IAccountRepository
    {
        private readonly string _connectionString;

        public SqlAccountRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Account account)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                const string query = @"insert into Accounts(Firstname, Lastname, Balance, LastAutoIncreaseDate) 
                        output inserted.id
                        values(@firstname, @lastname, @balance, @lastautoincreasedate)";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("firstname", account.Firstname);
                cmd.Parameters.AddWithValue("lastname", account.Lastname);
                cmd.Parameters.AddWithValue("balance", account.Balance);
                cmd.Parameters.AddWithValue("lastautoincreasedate", account.LastAutoIncreaseDate);

                account.Id = (int)cmd.ExecuteScalar();
            }
        }

        public void Update(Account account)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = @"
                update accounts set firstname=@firstname, lastname=@lastname,
                 balance=@balance,lastautoincreasedate=@lastautodate
                where id = @id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("firstname", account.Firstname);
                cmd.Parameters.AddWithValue("lastname", account.Lastname);
                cmd.Parameters.AddWithValue("balance", account.Balance);
                cmd.Parameters.AddWithValue("lastautodate", account.LastAutoIncreaseDate);
                cmd.Parameters.AddWithValue("id", account.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Account> Get()
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "select * from Accounts";

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                List<Account> accounts = new List<Account>();

                while(reader.Read())
                {
                    Account account = Read(reader);

                    accounts.Add(account);
                }

                return accounts;
            }
        }

        public Account Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "select * from Accounts where id=@id";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == false)
                {
                    return null;
                }
                
                return Read(reader);
            }
        }

        private Account Read(SqlDataReader reader)
        {
            return new Account
            {
                Id = (int)reader["Id"],
                Firstname = (string)reader["Firstname"],
                Lastname = (string)reader["Lastname"],
                Balance = (decimal)reader["Balance"],
                LastAutoIncreaseDate = (DateTime)reader["LastAutoIncreaseDate"]
            };
        }

        public void Delete(int id)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "delete from Accounts where id = @id";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
