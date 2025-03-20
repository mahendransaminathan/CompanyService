using CompanyService.Entities;
public interface ICompanyProvider
{
    void AddPerson(Company company);

    List<string> GetCompanyNames();
}