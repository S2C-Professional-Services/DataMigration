using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationOnGHistoryRecord
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public string BreastFed { get; set; }
        public string Week { get; set; }
        public string Notes { get; set; }
        public DateTime DeliveryDate { get; set; }
        public List<MigrationOnGBaby> Babies { get; set; }
    }
}
