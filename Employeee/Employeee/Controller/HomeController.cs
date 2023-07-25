
using Employeee.Model;
using Employeee.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeee.controller
{

    [Route("[controller]")]
    public class HomeController : Controller
    {
        public IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }


        [Route("")]
        [Route("[action]")]
        [Route("Index/{id?}")]
        public string Index(int? id) {
            return _employeeRepository.GetEmployee(id ?? 1).Name;
        }


        [Route("~/")]
        [Route("Details/{id?}")]
        public ViewResult Details(int? id) {
            HomeDetailsViewModel homeEmployeeDetails = new HomeDetailsViewModel() {

                Employee = _employeeRepository.GetEmployee(id ?? 2),
                Title = "Details of Employee"
            };

            return View(homeEmployeeDetails);
        }



        [Route("Details1")]
        public IActionResult Details1() {
            var modal = _employeeRepository.GetAllEmployee();
            return View(modal);
        }

        
    }
}

