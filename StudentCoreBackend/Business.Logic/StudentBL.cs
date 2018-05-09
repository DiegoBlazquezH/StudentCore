using System;
using System.Collections.Generic;
using System.Reflection;
using Common.Logic.Logger;
using Common.Logic.Models;
using Dao.Repository;

namespace Business.Logic
{
    public class StudentBL : IBusiness
    {
        private readonly ILogger log;
        private readonly IRepository repository;

        public StudentBL(ILogger log, IRepository repository)
        {
            this.log = log;
            this.repository = repository;
        }

        public Student Create(Student student)
        {
            try
            {
                log.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name);
                return repository.Create(student);
            }
            catch (Exception ex)
            {
                log.Exception(ex, MethodBase.GetCurrentMethod().DeclaringType.Name);
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                log.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name);
                repository.Delete(id);
            }
            catch (Exception ex)
            {
                log.Exception(ex, MethodBase.GetCurrentMethod().DeclaringType.Name);
                throw;
            }
        }

        public List<Student> GetAll()
        {
            try
            {
                log.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name);
                return repository.GetAll();
            }
            catch (Exception ex)
            {
                log.Exception(ex, MethodBase.GetCurrentMethod().DeclaringType.Name);
                throw;
            }
        }

        public Student SelectByGuid(Guid guid)
        {
            try
            {
                log.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name);
                return repository.SelectByGuid(guid);
            }
            catch (Exception ex)
            {
                log.Exception(ex, MethodBase.GetCurrentMethod().DeclaringType.Name);
                throw;
            }
        }

        public Student SelectById(int id)
        {
            try
            {
                log.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name);
                return repository.SelectById(id);
            }
            catch (Exception ex)
            {
                log.Exception(ex, MethodBase.GetCurrentMethod().DeclaringType.Name);
                throw;
            }
        }
    }
}
