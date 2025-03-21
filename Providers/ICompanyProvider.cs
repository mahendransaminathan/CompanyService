using CompanyService.Entities;

namespace CompanyService.Providers
{
    public interface ICompanyProvider
    {
        void AddPerson(Company company);

        List<string> GetCompanyNames();
    }
}