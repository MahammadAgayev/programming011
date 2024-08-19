using _40.Repositeries.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Repositeries.SqlServer
{
    internal class SqlUnitOfWork : IUnitOfWork
    {
        public IStudentRepository StudentRepository => new SqlServerStudentRepository();

        public IProductRepository ProductRepository => new SqlProductRepository();

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
