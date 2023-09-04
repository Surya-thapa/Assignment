using Assignment.Data;
using Assignment.Models;
using Assignment.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class EmployeesController : Controller
    {
      
        private readonly AssignDbContext _assignDbContext;

        public EmployeesController(AssignDbContext assignDbContext)
        {
            _assignDbContext = assignDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> IndexEmployee()
        {
            var employees= await _assignDbContext.Employees.ToListAsync();

         return View(employees);
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddEmployeeViewModel addEmployeeViewModel) 
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeViewModel.Name,
                Email = addEmployeeViewModel.Email,
                Phone = addEmployeeViewModel.Phone,
                Salary = addEmployeeViewModel.Salary,
                DateOfBirth = addEmployeeViewModel.DateOfBirth,
              

            };
            await _assignDbContext.Employees.AddAsync(employee);
            await _assignDbContext.SaveChangesAsync();
            return RedirectToAction("IndexEmployee");
        }
    }
}
