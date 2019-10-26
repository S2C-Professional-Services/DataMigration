using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2CDataMigrationConsole.Models
{
    public class MigrationAccountHolder
    {
        public int ExternalId { get; set; }
        public bool Individual { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MedicareNum { get; set; }
        public int MedicareRefNum { get; set; }
        public Nullable<DateTime> MedicareExpiryDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string[] PatientExternalIds { get; set; }        
    }
}
