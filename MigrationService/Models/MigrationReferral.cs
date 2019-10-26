using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationReferral
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public int ContactExternalId { get; set; }
        public DateTime ReferralDate { get; set; }
        public DateTime IssueDate { get; set; }
        public int Duration { get; set; }
    }
}
