using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Services
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid InvoiceItemId { get; set; }
        public decimal? BenefitAmount { get; set; }
        public string ExplanationCode { get; set; }
        public string MedicareServiceId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal ChargeAmount { get; set; }
        public string HealthFundExplanation { get; set; }
        public bool? Resolved { get; set; }
        public string MedicareVoucherId { get; set; }
        public Guid ClaimId { get; set; }

        public virtual Claims Claim { get; set; }
        public virtual InvoiceItems InvoiceItem { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
