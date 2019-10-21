using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class PrescriptionAuthorities
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PrescriptionId { get; set; }
        public int? AuthorityFormNumberId { get; set; }
        public string RestrictionCode { get; set; }
        public string AuthorityCode { get; set; }
        public DateTime? EmergencyCallAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public string ClinicalReason { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual Prescriptions Prescription { get; set; }
    }
}
