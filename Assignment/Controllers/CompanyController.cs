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
        public IActionResult AddCompany(Guid id) 
        {
            AddCompanyDTO addcomp = new AddCompanyDTO();
            if(id != Guid.Empty)
            {
                addcomp.Id = id;
                var company = _assignDbContext.Company.FirstOrDefault(x => x.Id == id);
                addcomp.CompanyName = company.CompanyName;
                addcomp.CompanyPhone = company.CompanyPhone;
                addcomp.CompanyEmail = company.CompanyEmail;
                addcomp.CompanyDescription = company.CompanyDescription;
            }
            return View();
        }
    }
}
