using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationInterestedParty
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public int ContactExternalId { get; set; }
    }
}
