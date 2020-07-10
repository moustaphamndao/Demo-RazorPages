using Demo_RazorPages.Models;
using System;
using System.Collections.Generic;

namespace Demo_RazorPages.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee Update(Employee updatedEmployee);
    }
}
