using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationOnGAntenatal
    {
        public int ExternalId { get; set; }
        public int OnGRecordExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public int UserExternalId { get; set; }
        public DateTime VisitDate { get; set; }
        public int Bp { get; set; }
        public int AppointmentExternalId { get; set; }
    }
}
