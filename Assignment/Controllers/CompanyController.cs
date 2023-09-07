using Assignment.Data;
using Assignment.Models.Domain;
using Assignment.ViewModels.Company;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class CompanyController : Controller
    {
        private readonly AssignDbContext _assignDbContext;

        public CompanyController(AssignDbContext assignDbContext)
        {
          _assignDbContext = assignDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> IndexCompany()
        {
          var companydata = await _assignDbContext.Company
                .Select(x => new CompanyDTO
            {
                Id = x.Id,
                CompanyName = x.CompanyName,
                CompanyPhone = x.CompanyPhone,
                CompanyEmail = x.CompanyEmail,
                CompanyDescription = x.CompanyDescription
            }).ToListAsync();

            return View(companydata);
        }
        [HttpGet]
        public IActionResult AddCompany()
        {
            AddCompanyDTO model = new AddCompanyDTO();
          
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddCompany(AddCompanyDTO model)
        {
            Company com = new Company()
            {
                CompanyName = model.CompanyName,
                CompanyPhone = model.CompanyPhone,
                CompanyEmail = model.CompanyEmail,
                CompanyDescription = model.CompanyDescription
            };
            await _assignDbContext.Company.AddAsync(com);
            await _assignDbContext.SaveChangesAsync();

            return RedirectToAction("IndexCompany");
        }
        [HttpGet]
        public IActionResult UpdateCompany()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateCompany(UpdateCompanyDTO model)
        {
            return RedirectToAction("IndexCompany");
        }

    }
}
