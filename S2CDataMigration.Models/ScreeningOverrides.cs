using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ScreeningOverrides
    {
        public Guid Id { get; set; }
        public string AdditionalText { get; set; }
        public Guid PracticeId { get; set; }
        public Guid MedicationId { get; set; }
        public Guid InteractionId { get; set; }
        public Guid? ReasonId { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ReasonText { get; set; }

        public virtual ScreeningInteractions Interaction { get; set; }
        public virtual Medications Medication { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ScreeningOverrideReasons Reason { get; set; }
    }
}
