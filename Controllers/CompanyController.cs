using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using CompanyService.Entities;
using CompanyService.Services;
namespace CompanyService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowLocalhost")]
    public class CompanyController : ControllerBase
    {
        ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService ?? throw new ArgumentNullException(nameof(companyService));
        }
        [HttpPost] // POST: api/company
        public IActionResult AddCompany([FromBody] Company company)
        {            
           companyService.AddCompany(company);

           return Ok(company);            
        }        
    }
}