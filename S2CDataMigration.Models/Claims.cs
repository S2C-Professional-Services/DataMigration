using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Claims
    {
        public Claims()
        {
            ClaimInvoiceNotes = new HashSet<ClaimInvoiceNotes>();
            ClaimsInvoices = new HashSet<ClaimsInvoices>();
            Services = new HashSet<Services>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string ClaimType { get; set; }
        public string MedicareTransactionId { get; set; }
        public string ErrorCode { get; set; }
        public int? ReferenceNumberId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string MedicareClaimId { get; set; }
        public int? SentCount { get; set; }
        public string ClaimStatus { get; set; }
        public DateTime? SentOn { get; set; }
        public DateTime? FinalisedOn { get; set; }
        public string PaymentReference { get; set; }
        public string RequestFileName { get; set; }
        public string RequestContentType { get; set; }
        public int? RequestFileSize { get; set; }
        public DateTime? RequestUpdatedAt { get; set; }
        public string ProcessingReportFileName { get; set; }
        public string ProcessingReportContentType { get; set; }
        public int? ProcessingReportFileSize { get; set; }
        public DateTime? ProcessingReportUpdatedAt { get; set; }
        public string PaymentReportFileName { get; set; }
        public string PaymentReportContentType { get; set; }
        public int? PaymentReportFileSize { get; set; }
        public DateTime? PaymentReportUpdatedAt { get; set; }
        public DateTime? ReportedOn { get; set; }
        public string AdditionalInformation { get; set; }
        public string[] EraTransactionIds { get; set; }
        public DateTime? ResubmittedOn { get; set; }
        public bool ReportError { get; set; }
        public string PaymentReportFingerprint { get; set; }
        public string ProviderNumber { get; set; }
        public bool Reviewed { get; set; }
        public decimal? BenefitAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public DateTime? PaidOn { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ICollection<ClaimInvoiceNotes> ClaimInvoiceNotes { get; set; }
        public virtual ICollection<ClaimsInvoices> ClaimsInvoices { get; set; }
        public virtual ICollection<Services> Services { get; set; }
    }
}
