using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class PastProcedures
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid? ProcedureAttributeId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Notes { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ClinicalHistoryAttributes ProcedureAttribute { get; set; }
    }
}
