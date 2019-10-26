using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationLaboratoryResult
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public int DoctorExternalId { get; set; }
        public string LaboratoryResultType { get; set; }
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public string DoctorName { get; set; }
        public string DoctorLastName { get; set; }
        public DateTime PatientDateOfBirth { get; set; }
        public string ResultName { get; set; }
        public string FormattedResult { get; set; }
        public DateTime ImportDate { get; set; }
    }
}
