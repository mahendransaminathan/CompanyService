using CompanyService.Entities;

namespace CompanyService.Services
{
    public interface ICompanyService
    {
        void AddCompany(Company company);

        List<string> GetCompanyNames();
    }
}
