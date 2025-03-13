using CompanyService.Data;
using CompanyService.Entities;
using CompanyService.Providers;

namespace CompanyService.Providers
{
    public class CompanyProvider : ICompanyProvider
    {
        private readonly ApplicationDBContext? dbContext;

        public CompanyProvider()
        {
         
        }
        public CompanyProvider(ApplicationDBContext dbContext)
        {            
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public virtual void AddPerson(Company company)
        {
           if (dbContext == null)
            {
                throw new InvalidOperationException("Database context is not available.");
            }

            dbContext.Companies.Add(company);
            dbContext.SaveChanges();    
        }       
    }         
}