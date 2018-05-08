using System;
using System.Collections.Generic;
using System.Text;
using Common.Logic.Model;

namespace Business.Logic
{
    public class BLService : IBLService
    {
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student
            {
                GUID = Guid.NewGuid(),
                ID = 1,
                Name = "Tomasin",
                Surname = "Rojo",
                DNI = "123456789A",
                BirthDate = DateTime.Now,
                Age = 15,
                RegisterDate = DateTime.Now
            };

            Student student2 = new Student
            {
                GUID = Guid.NewGuid(),
                ID = 2,
                Name = "Lechugo",
                Surname = "Verde",
                DNI = "987654321Z",
                BirthDate = DateTime.Now,
                Age = 20,
                RegisterDate = DateTime.Now
            };

            students.Add(student1);
            students.Add(student2);

            return students;
        }
    }
}
