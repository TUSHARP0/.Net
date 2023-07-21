using HRWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BOL;
using System.Collections.Generic;
using DAL;
namespace HRWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Employees()
        {
            List<Employee> empList = DBManager.GetEmployees();
            ViewBag.ListOfEmployees = empList;

            return View();
        }
        [HttpPost]
        public IActionResult Register(string id, string empname, string designation, string department, string city, string salary,string joinDate)
        {
            Employee emp = new Employee(int.Parse(id),empname,designation,Enum.Parse<Department>(department),city,double.Parse(salary),DateOnly.FromDateTime(DateTime.Parse(joinDate)));
            DBManager.insertEmployee(emp);
            /*List<Employee> empList=DBManager.GetEmployees();
            ViewBag.ListOfEmployees = empList;*/
            return RedirectToAction("Employees");
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            DBManager.deleteEmployee(id);            
            return RedirectToAction("Employees");
        }


        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult GetById(int id)
        {
            Employee emp=DBManager.getById(id);
            if(emp != null)
            {
                ViewBag.FOUNDEMP = emp; 
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(string id, string empname, string designation, string department, string city, string salary,string joinDate)
        {
            Employee updateEmp = new Employee(int.Parse(id), empname, designation, Enum.Parse<Department>(department), city, double.Parse(salary), DateOnly.FromDateTime(DateTime.Parse(joinDate)));
            DBManager.updateEmployee(updateEmp);
            return RedirectToAction("Employees");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}