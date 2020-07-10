using Demo_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_RazorPages.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;


        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Jean", Department = Dept.HR,
                    Email = "jean@ndawene.com", PhotoPath="jean.png" },
                new Employee() { Id = 2, Name = "Nicolas", Department = Dept.IT,
                    Email = "nicolas@ndawene.com", PhotoPath="nicolas.jpg" },
                new Employee() { Id = 3, Name = "Sophie", Department = Dept.IT,
                    Email = "sophie@ndawene.com", PhotoPath="sophie.jpeg" },
                new Employee() { Id = 4, Name = "David", Department = Dept.Payroll,
                    Email = "david@ndawene.com" },
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee updatedEmployee)
        {
            Employee employeeToUpdate = _employeeList.FirstOrDefault(e => e.Id == updatedEmployee.Id);

            if (employeeToUpdate != null)
            {
                employeeToUpdate.Name = updatedEmployee.Name;
                employeeToUpdate.Email = updatedEmployee.Email;
                employeeToUpdate.Department = updatedEmployee.Department;
                employeeToUpdate.PhotoPath = updatedEmployee.PhotoPath;
            }

            return employeeToUpdate;

        }
    }
}

