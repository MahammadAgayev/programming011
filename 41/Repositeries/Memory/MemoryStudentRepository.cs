using _40.Entities;
using _40.Repositeries.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _40.Repositeries.Memory
{
    internal class MemoryStudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new List<Student>();

        public void Add(Student student)
        {
            student.Id = _students.Count;
            _students.Add(student);
        }

        public void Delete(int id)
        {
            _students.RemoveAll(x => x.Id == id);
        }

        public Student Get(int id)
        {
            foreach (Student student in _students)
            {
                if (student.Id == id)
                    return student;
            }

            return null;
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public void Update(Student student)
        {
            foreach(Student item in _students)
            {
                if(item.Id == student.Id)
                {
                    item.Firstname = student.Firstname;
                    item.Lastname = student.Lastname;
                }
            }
        }
    }
}
