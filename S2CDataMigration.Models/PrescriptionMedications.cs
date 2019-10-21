using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class PrescriptionMedications
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? PrescriptionId { get; set; }
        public Guid? MedicationId { get; set; }
        public Guid? VersionId { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Practices Practice { get; set; }
    }
}
