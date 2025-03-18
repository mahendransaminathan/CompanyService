using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CompanyService.Entities
{
    public class Company
    {
        [JsonProperty("id")] // Ensures the field is recognized as "id" in Cosmos DB
        public required string Id { get; set; } 
        public required string CompanyName { get; set; }
        public required string RegistrationNumber { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string Country { get; set; }
        public required string Eircode { get; set; }     
        
    }
}