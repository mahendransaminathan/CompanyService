
using CompanyService.Entities;
using CompanyService.Providers;
using CompanyService.Services; // Add this line

namespace CompanyService.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyProvider provider;

        public CompanyService(ICompanyProvider companyProvider)
        {
            this.provider = companyProvider ?? throw new ArgumentNullException(nameof(companyProvider));
        }

        public void AddCompany(Company company)
        {
                       
            if (company == null)
            {
                throw new ArgumentException("Person data is required.");
            }
            var newCompany = new Company
            {
                Id = company.Id,
                CompanyName = company.CompanyName,
                RegistrationNumber = company.RegistrationNumber,
                Address = company.Address,
                City = company.City,
                State = company.State,
                Country = company.Country,
                Eircode = company.Eircode
            };
            Console.WriteLine("Person Data: " + company);       

            provider.AddPerson(company); 
        }

        public List<string> GetCompanyNames()
        {
            return provider.GetCompanyNames();            
        }
    }
}