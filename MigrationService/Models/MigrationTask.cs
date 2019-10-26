using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationTask
    {
        public int ExternalId { get; set; }
        public int FromUserExternalId { get; set; }
        public int ToUserExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsFinished { get; set; }
        public bool IsUrgent { get; set; }
        public string Subject { get; set; }
    }
}
