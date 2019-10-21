using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Diagnoses
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid? DiagnosisAttributeId { get; set; }
        public string Onset { get; set; }
        public string Resolved { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool? Active { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }

        public virtual ClinicalHistoryAttributes DiagnosisAttribute { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
