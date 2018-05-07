using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Logic;
using Common.Logic.Log;
using Common.Logic.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly ILogger log;
        private readonly IBusiness studentBl;

        public StudentController(ILogger log, IBusiness studentBl)
        {
            this.log = log;
            this.studentBl = studentBl;
        }
        
        // GET api/student
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(studentBl.GetAll());
        }

        // GET api/student/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(studentBl.SelectById(id));
        }

        // POST api/student
        [HttpPost]
        public IActionResult Post([FromBody]Student student)
        {
            return Ok(studentBl.Create(student));
        }

        // PUT api/student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
