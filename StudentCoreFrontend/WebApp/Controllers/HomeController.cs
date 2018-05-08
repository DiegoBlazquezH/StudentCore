using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Logic;
using Common.Logic.Model;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBLService blService;

        public HomeController(IBLService dataService)
        {
            blService = dataService;
        }

        public IActionResult Index()
        {
            List<Student> students = blService.GetAll();
            return View(students);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
