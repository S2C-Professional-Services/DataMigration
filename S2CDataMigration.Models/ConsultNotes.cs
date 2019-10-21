using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ConsultNotes
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public DateTime ConsultAt { get; set; }
        public string Reason { get; set; }
        public string History { get; set; }
        public string Plan { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public string Examination { get; set; }
        public Guid? RestrictedById { get; set; }
        public DateTime? RestrictedAt { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Users RestrictedBy { get; set; }
    }
}
