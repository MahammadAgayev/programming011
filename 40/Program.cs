using _40.Repositeries.Abstract;
using _40.Repositeries.Memory;
using _40.Repositeries.SqlServer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Design patterns

            //Dizayn qəlibləri
            //Clean code

            //Repository design pattern

            //Entity -> Verilənlər bazasındakı cədvəlin koddakı yansımasıdır

            //UnitOfWork
            //IStudentRepository repository = new SqlServerStudentRepository();

            //repository.Add(new Entities.Student
            //{
            //    Firstname = "Mahammad",
            //    Lastname = "Aghayev"
            //});

            //var students = repository.GetAll();

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Firstname);
            //}


            //IUnitOfWork unitOfWork = new SqlUnitOfWork();
            //unitOfWork.StudentRepository.Add(new Entities.Student());
            //unitOfWork.ProductRepository.Add(new Entities.Product());

            //unitOfWork.SaveChanges();
        }
    }
}
