using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationRecall
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public int DoctorExternalId { get; set; }
        public string Reason { get; set; }
        public int RecurrenceInterval { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime NextCallDate { get; set; }
        public DateTime DateEntered { get; set; }
        public string DoctorFullName { get; set; }
        public string PatientPhone { get; set; }
        public DateTime LastActionDate { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime NextAppointmentDate { get; set; }
        public bool SetSendSms { get; set; }
    }
}
