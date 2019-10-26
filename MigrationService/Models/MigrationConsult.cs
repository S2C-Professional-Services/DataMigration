using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationConsult
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public DateTime StartConsult { get; set; }
        public int UserExternalId { get; set; }
        public int AppointmentExternalId { get; set; }
    }
}
