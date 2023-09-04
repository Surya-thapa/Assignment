using Assignment.Data;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AssignDbContext _assignDbContext;
        public DepartmentController(AssignDbContext assignDbContext)
        {
         _assignDbContext = assignDbContext;
        }
       
        public IActionResult AddDepartment()
        {
            return View(); ;
        }
        public IActionResult IndexDepartment()
        {
            return View();
        }
    }
}
