using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class InvoiceItems
    {
        public InvoiceItems()
        {
            InvoiceItemTxns = new HashSet<InvoiceItemTxns>();
            Services = new HashSet<Services>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? VoucherId { get; set; }
        public Guid BillingItemId { get; set; }
        public decimal? Fee { get; set; }
        public decimal? Rebate { get; set; }
        public bool? MultipleProcedureApplied { get; set; }
        public string ServiceText { get; set; }
        public string NotRestrictiveOverrides { get; set; }
        public int Overrides { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string ClaimStatus { get; set; }
        public Guid InvoiceableId { get; set; }
        public string ServicingProviderType { get; set; }
        public Guid? ServicingProviderId { get; set; }
        public DateTime? ServicedOn { get; set; }
        public TimeSpan? ServiceTime { get; set; }
        public string AdditionalInformation { get; set; }
        public bool GstIncluded { get; set; }
        public Guid? RequestingProviderId { get; set; }
        public DateTime? RequestedOn { get; set; }
        public string NoRequestReason { get; set; }

        public virtual BillingItems BillingItem { get; set; }
        public virtual Invoices Invoiceable { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Contacts RequestingProvider { get; set; }
        public virtual Vouchers Voucher { get; set; }
        public virtual ICollection<InvoiceItemTxns> InvoiceItemTxns { get; set; }
        public virtual ICollection<Services> Services { get; set; }
    }
}
