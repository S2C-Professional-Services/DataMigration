using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationAllergy
    {
        public int PatientExternalId { get; set; }
        public List<string> Allergies { get; set; }
    }
}
