using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Prescriptions
    {
        public Prescriptions()
        {
            PrescriptionAuthorities = new HashSet<PrescriptionAuthorities>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid ProviderId { get; set; }
        public Guid? FirstScriptId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public int NumberId { get; set; }
        public string PrescriberName { get; set; }
        public string PrescriberNumber { get; set; }
        public string PrescriberType { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Users Provider { get; set; }
        public virtual ICollection<PrescriptionAuthorities> PrescriptionAuthorities { get; set; }
    }
}
