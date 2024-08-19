using _40.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Repositeries.Abstract
{
    internal interface IStudentRepository
    {
        Student Get(int id);
        List<Student> GetAll();

        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
