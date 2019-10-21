using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Txns
    {
        public Txns()
        {
            InvoiceItemTxns = new HashSet<InvoiceItemTxns>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid AccountId { get; set; }
        public Guid UserId { get; set; }
        public DateTime TransactedAt { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string TxnType { get; set; }
        public Guid? CreatorId { get; set; }
        public decimal Gst { get; set; }
        public bool IsPayment { get; set; }
        public Guid? ReversedPaymentId { get; set; }
        public string PaymentReference { get; set; }
        public Guid? UpdaterId { get; set; }
        public DateTime? EmailedAt { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<InvoiceItemTxns> InvoiceItemTxns { get; set; }
    }
}
