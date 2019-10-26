using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2CDataMigrationConsole.Models
{
   public class MigrationContact
    {
        public int ExternalId { get; set; }  
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Alltalk { get; set; }
        public string Argus { get; set; }
        public string Category { get; set; }
        public string CompanyName { get; set; }
        public string DivisionReport { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string HealthLink { get; set; }
        public string LastName { get; set; }
        public string MedicalObjects { get; set; }
        public string MiddleName { get; set; }
        public string ProviderNo { get; set; }
        public string ReferralNet { get; set; }
        public string Fax { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string HPI { get; set; }
        public string Salutation { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public bool IsAssistant { get; set; }
        public bool IsSpecialist { get; set; }
        public string Specialty { get; set; }       

    }
}
