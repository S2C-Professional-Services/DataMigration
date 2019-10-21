using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ClaimInvoiceNotes
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid ClaimId { get; set; }
        public Guid InvoiceId { get; set; }
        public string Note { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Latest { get; set; }

        public virtual Claims Claim { get; set; }
        public virtual Invoices Invoice { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
