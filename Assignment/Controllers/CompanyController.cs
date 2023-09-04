using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult IndexCompany()
        {
            return View();
        }

        public IActionResult AddCompany() 
        {
            return View();
        }
    }
}
