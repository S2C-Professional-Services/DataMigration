using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class InvoiceItemTxns
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid InvoiceItemId { get; set; }
        public Guid TxnId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid InvoiceId { get; set; }
        public decimal Gst { get; set; }

        public virtual Invoices Invoice { get; set; }
        public virtual InvoiceItems InvoiceItem { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Txns Txn { get; set; }
    }
}
