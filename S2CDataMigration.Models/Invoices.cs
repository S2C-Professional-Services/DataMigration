using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Invoices
    {
        public Invoices()
        {
            ClaimInvoiceNotes = new HashSet<ClaimInvoiceNotes>();
            ClaimsInvoices = new HashSet<ClaimsInvoices>();
            InvoiceItemTxns = new HashSet<InvoiceItemTxns>();
            InvoiceItems = new HashSet<InvoiceItems>();
            Vouchers = new HashSet<Vouchers>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? SiteOfServiceId { get; set; }
        public Guid? HealthFundId { get; set; }
        public Guid? AccountId { get; set; }
        public Guid? GapAssigneeId { get; set; }
        public Guid? HospitalId { get; set; }
        public string Note { get; set; }
        public string AccountType { get; set; }
        public string RebateType { get; set; }
        public string BillingType { get; set; }
        public int? ReferenceNumberId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public bool Committed { get; set; }
        public string ClaimStatus { get; set; }
        public string Type { get; set; }
        public Guid? ReferralId { get; set; }
        public string NoReferralReason { get; set; }
        public string TreatmentLocation { get; set; }
        public int? DistanceTravelled { get; set; }
        public Guid? QuoteId { get; set; }
        public string MprType { get; set; }
        public Guid? FeeScheduleId { get; set; }
        public Guid? ThirdPartyClaimId { get; set; }
        public DateTime? EmailedAt { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual FeeSchedules FeeSchedule { get; set; }
        public virtual Accounts GapAssignee { get; set; }
        public virtual HealthFunds HealthFund { get; set; }
        public virtual Contacts Hospital { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Referrals Referral { get; set; }
        public virtual SitesOfService SiteOfService { get; set; }
        public virtual ThirdPartyClaims ThirdPartyClaim { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<ClaimInvoiceNotes> ClaimInvoiceNotes { get; set; }
        public virtual ICollection<ClaimsInvoices> ClaimsInvoices { get; set; }
        public virtual ICollection<InvoiceItemTxns> InvoiceItemTxns { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
        public virtual ICollection<Vouchers> Vouchers { get; set; }
    }
}
