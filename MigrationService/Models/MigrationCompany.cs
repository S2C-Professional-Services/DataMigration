using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationCompany
    {
        public int ExternalId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Name { get; set; }
        public string ContactPersonName { get; set; }
        public string TypeOfBusiness { get; set; }
        public string ProviderNo { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
    }
}
