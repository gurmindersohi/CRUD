using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD.Services
{
    public interface IEmployeeServices
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
