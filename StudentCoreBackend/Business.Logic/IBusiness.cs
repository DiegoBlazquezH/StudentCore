using Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Logic
{
    public interface IBusiness
    {
        Student Create(Student student);
        List<Student> GetAll();
        void Delete(int id);
        Student SelectByGuid(Guid guid);
        Student SelectById(int id);
    }
}
