using CompanyService.Data;
using CompanyService.Entities;
using CompanyService.Providers;
using Microsoft.Azure.Cosmos;

namespace CompanyService.Providers
{
    public class CompanyProvider : ICompanyProvider
    {
        private readonly CosmosClient mCosmosClient;
        private readonly Database mDatabase;

        private readonly Container mContainer;

        public CompanyProvider()
        {
         
        }
        public CompanyProvider(CosmosClient cosmosClient, IConfiguration configuration)
        {
            mCosmosClient = cosmosClient;

            mDatabase = mCosmosClient.GetDatabase(configuration["CosmosDb:DatabaseName"]);

            mContainer = mDatabase.GetContainer(configuration["CosmosDb:ContainerName"]);

        }

        public async void AddPerson(Company company)
        {
           if (string.IsNullOrEmpty(company.Id.ToString()))
            {
                company.Id = Guid.NewGuid().ToString();

            }

            await mContainer.CreateItemAsync(company, new PartitionKey(company.Id.ToString()));

        }       

        public List<string> GetCompanyNames()
        {
            return mContainer.GetItemLinqQueryable<Company>(true).Select(x => x.CompanyName).ToList();
        }
    }         
}