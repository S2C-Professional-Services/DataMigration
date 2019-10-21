using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class BillingItemsProcedures
    {
        public Guid Id { get; set; }
        public Guid BillingItemId { get; set; }
        public Guid ProcedureId { get; set; }
        public Guid PracticeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual BillingItems BillingItem { get; set; }
        public virtual Procedures Procedure { get; set; }
    }
}
