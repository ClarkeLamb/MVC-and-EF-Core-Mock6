using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mock6.Models;
using Mock6.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mock6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, EmployeeRepo employeeRepo, EmployeeDbContext employeeDbContext)
        {
            _logger = logger;
            _employeeRepo = employeeRepo;
            _employeeDbContext = employeeDbContext;
        }
        private readonly EmployeeRepo _employeeRepo;
        private readonly EmployeeDbContext _employeeDbContext;


        public async Task<IActionResult> Employees()
        {
            var model = await _employeeRepo.GetEmployeesAsync();
            return View(model);
        }

        public IActionResult RetirementInfo(int Id)
        {
            var employee = _employeeDbContext.Employees.Find(Id);
            if(employee.Age > 60)
            {
                ViewBag.CanRetire = true;
            }
            else
            {
                ViewBag.CanRetire = false;
            }

            ViewBag.Benefits = employee.Salary * 60/100;

            return View();           
            
           
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
