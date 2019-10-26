using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationDocument
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public DateTime ImageDate { get; set; }
        public string FileName { get; set; }
        public DateTime DocumentDate { get; set; }
    }
}
