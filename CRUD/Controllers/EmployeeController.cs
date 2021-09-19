using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Services;
using Microsoft.AspNetCore.Mvc;


namespace CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeeController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _employeeServices.GetEmployees();
            return View(model);
        }
    }
}
