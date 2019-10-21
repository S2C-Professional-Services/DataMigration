using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class AdverseReactions
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid? AgentAttributeId { get; set; }
        public Guid? ManifestationAttributeId { get; set; }
        public string Agent { get; set; }
        public string Manifestation { get; set; }
        public string Note { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public string Severity { get; set; }
        public string AgentCode { get; set; }
        public string AgentCodeSystem { get; set; }
        public string ManifestationCode { get; set; }
        public string ManifestationCodeSystem { get; set; }
        public bool? Flagged { get; set; }

        public virtual ClinicalHistoryAttributes AgentAttribute { get; set; }
        public virtual ClinicalHistoryAttributes ManifestationAttribute { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
