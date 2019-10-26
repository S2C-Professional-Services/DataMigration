using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationAppointmentType
    {
        public int ExternalId { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Duration { get; set; }
    }
}
