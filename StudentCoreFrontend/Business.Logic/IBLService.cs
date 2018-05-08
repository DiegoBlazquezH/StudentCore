using Common.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Logic
{
    public interface IBLService
    {
        List<Student> GetAll();
    }
}
