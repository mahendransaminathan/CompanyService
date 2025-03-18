using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CompanyService.Entities
{
    public class Company
    {
        [JsonProperty("id")] // Ensures the field is recognized as "id" in Cosmos DB
        public required string Id { get; set; } 
        [JsonProperty("companyName")]
        public required string CompanyName { get; set; }

        [JsonProperty("registrationNumber")]
        public required string RegistrationNumber { get; set; }

        [JsonProperty("address")]
        public required string Address { get; set; }

        [JsonProperty("city")]
        public required string City { get; set; }

        [JsonProperty("state")]
        public required string State { get; set; }

        [JsonProperty("country")]
        public required string Country { get; set; }

        [JsonProperty("eircode")]
        public required string Eircode { get; set; }
        
    }
}