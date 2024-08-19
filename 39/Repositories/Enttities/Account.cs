using System;

namespace _39.Enttities
{
    public class Account
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastAutoIncreaseDate { get; set; }
    }
}
