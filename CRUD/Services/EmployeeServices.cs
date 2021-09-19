using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly AppDbContext context;

        public EmployeeServices(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            List<Employee> employees = await context.Employees.ToListAsync();
            return employees;
        }
    }
}
