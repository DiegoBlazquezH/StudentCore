using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Logic.Logger;
using Common.Logic.Models;
using Dao.DataBaseContext;

namespace Dao.Repository
{
    public class RepositorySql : IRepository
    {
        private readonly ILogger log;
        private StudentContext studentContext;

        public RepositorySql(ILogger log, StudentContext studentContext)
        {
            this.log = log;
            this.studentContext = studentContext;
        }

        public Student Create(Student student)
        {
            using (var context = this.studentContext)
            {
                context.Students.Add(student);
                context.SaveChanges();

                return SelectById(student.ID);
            }
        }

        public void Delete(int id)
        {
            using (var context = this.studentContext)
            {
                var studentToDelete = context.Students.Find(id);
                context.Students.Remove(studentToDelete);
                context.SaveChanges();
            }
        }

        public List<Student> GetAll()
        {
            using (var context = this.studentContext)
            {
                return context.Students.ToList<Student>();
            }
        }

        public Student SelectByGuid(Guid guid)
        {
            using (var context = this.studentContext)
            {
                return context.Students
                    .Where(stu => stu.GUID == guid)
                    .FirstOrDefault();
            }
        }

        public Student SelectById(int id)
        {
            using (var context = this.studentContext)
            {
                return this.studentContext.Students.Find(id);
            }
        }
    }
}
