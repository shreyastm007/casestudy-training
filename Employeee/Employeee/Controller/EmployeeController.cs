using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeee.Controller
{
    public class EmployeeController : ControllerBase
    {
        public EmployeeController _employeeRepository;
        [HttpGet]
        public int test() {
            return 20;
        }
    }
}
