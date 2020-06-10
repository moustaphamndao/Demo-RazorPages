using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_RazorPages.Models;
using Demo_RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo_RazorPages.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public IEnumerable<Employee> Employees { get; set; }
        public IndexModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        
        public void OnGet()
        {
            Employees = employeeRepository.GetAllEmployees();
        }
    }
}