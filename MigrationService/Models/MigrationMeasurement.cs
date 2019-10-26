using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationMeasurement
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
