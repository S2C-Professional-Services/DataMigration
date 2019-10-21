using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Vouchers
    {
        public Vouchers()
        {
            InvoiceItems = new HashSet<InvoiceItems>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? InvoiceableId { get; set; }
        public Guid? ReferralId { get; set; }
        public string ServicingProviderType { get; set; }
        public Guid? ServicingProviderId { get; set; }
        public int InvoiceItemsCount { get; set; }
        public DateTime? ServicedOn { get; set; }
        public TimeSpan? ServiceTime { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string NoReferralReason { get; set; }
        public string TreatmentLocation { get; set; }
        public int? DistanceTravelled { get; set; }

        public virtual Invoices Invoiceable { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Referrals Referral { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
    }
}
