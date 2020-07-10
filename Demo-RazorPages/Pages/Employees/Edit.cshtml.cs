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
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Employee Employee { get; set; }
        public IActionResult OnGet(int id)
        {
            Employee = this.employeeRepository.GetEmployee(id);

            if (Employee == null)
            {
                return RedirectToAction("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(Employee employee)
        {
            Employee = this.employeeRepository.Update(employee);
            return RedirectToPage("Index");

        }
    }
}