using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ProcedureReferences
    {
        public Guid Id { get; set; }
        public Guid ProcedureId { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? ProcedureAttributeId { get; set; }
        public string Name { get; set; }
        public bool Optional { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual Procedures Procedure { get; set; }
        public virtual ClinicalHistoryAttributes ProcedureAttribute { get; set; }
    }
}
