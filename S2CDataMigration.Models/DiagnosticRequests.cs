using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class DiagnosticRequests
    {
        public DiagnosticRequests()
        {
            DiagnosticRequestCcs = new HashSet<DiagnosticRequestCcs>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid? RequestLabId { get; set; }
        public string DoctorCode { get; set; }
        public Guid RequesterId { get; set; }
        public string Tests { get; set; }
        public string Reason { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public bool Received { get; set; }
        public bool Urgent { get; set; }
        public int? ReferenceNumber { get; set; }
        public bool PreventHealthRecordUpload { get; set; }
        public string Type { get; set; }
        public string RequestLabName { get; set; }
        public string DeliveryMethod { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual RequestLabs RequestLab { get; set; }
        public virtual Users Requester { get; set; }
        public virtual ICollection<DiagnosticRequestCcs> DiagnosticRequestCcs { get; set; }
    }
}
