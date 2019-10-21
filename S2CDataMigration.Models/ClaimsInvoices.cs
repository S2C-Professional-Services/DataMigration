using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ClaimsInvoices
    {
        public Guid Id { get; set; }
        public Guid InvoiceId { get; set; }
        public Guid ClaimId { get; set; }
        public Guid PracticeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Claims Claim { get; set; }
        public virtual Invoices Invoice { get; set; }
    }
}
