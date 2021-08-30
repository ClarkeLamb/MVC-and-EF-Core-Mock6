using Microsoft.EntityFrameworkCore;
using Mock6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mock6.Repository
{
    public class EmployeeRepo
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeRepo(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var employees = await _employeeDbContext.Employees.ToListAsync();
            return employees;
        }

        //public async Task<Employee> FindEmployeeAsync(int Id)
        //{
        //    if()
        //}
    }
}
