using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ClinicalInteractionSettings
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PracticeId { get; set; }
        public bool? OverrideReason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string InteractionSeverity { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual Users User { get; set; }
    }
}
