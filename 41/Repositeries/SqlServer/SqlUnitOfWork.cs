using _40.Repositeries.Abstract;

using System;
using System.Data;

namespace _40.Repositeries.SqlServer
{
    internal class SqlUnitOfWork : IUnitOfWork
    {
        public SqlUnitOfWork(int connectionTimeout, int transactionTimeout, IsolationLevel isolationLevel)
        {
            ConnectionTimeout = connectionTimeout;
            TransactionTimeout = transactionTimeout;
            IsolationLevel = isolationLevel;
        }   

        public int ConnectionTimeout { get; set; }
        public int TransactionTimeout { get; set; }
        public IsolationLevel IsolationLevel { get; set; }

        public IStudentRepository StudentRepository => new SqlServerStudentRepository();
        public IProductRepository ProductRepository => new SqlProductRepository();

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
