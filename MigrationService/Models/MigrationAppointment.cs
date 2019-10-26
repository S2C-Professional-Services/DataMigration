using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationAppointment
    {
        public int ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int CreatedByExternalId { get; set; }
        public DateTime CreationDate { get; set; }
        public int UserExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public int AppointmentTypeExternalId { get; set; }
    }
}
