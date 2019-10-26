using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationLetter
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public int ContactExternalId { get; set; }
        public int AuthorExternalId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
    }
}
