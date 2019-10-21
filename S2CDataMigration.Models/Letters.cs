using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Letters
    {
        public Letters()
        {
            Recipients = new HashSet<Recipients>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid SenderId { get; set; }
        public string[] Disposition { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string AddresseeName { get; set; }
        public string CcNames { get; set; }
        public bool CcPatient { get; set; }
        public string Content { get; set; }
        public DateTime? SentAt { get; set; }
        public DateTime? PrintedAt { get; set; }
        public string DeliveredTo { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public string Header { get; set; }
        public string Label { get; set; }
        public string TemplateConfig { get; set; }
        public Guid? RestrictedById { get; set; }
        public DateTime? RestrictedAt { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Users RestrictedBy { get; set; }
        public virtual Users Sender { get; set; }
        public virtual ICollection<Recipients> Recipients { get; set; }
    }
}
