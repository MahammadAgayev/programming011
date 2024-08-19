using _40.Repositeries.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Repositeries.Memory
{
    internal class MemoryUnitOfWork : IUnitOfWork
    {
        public IStudentRepository StudentRepository => throw new NotImplementedException();

        public IProductRepository ProductRepository => throw new NotImplementedException();

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
