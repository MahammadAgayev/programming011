using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Repositeries.Abstract
{
    internal interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }
        IProductRepository ProductRepository { get; }

        void SaveChanges();
    }
}
