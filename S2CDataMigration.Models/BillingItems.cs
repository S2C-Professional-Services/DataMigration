using System;
using System.Collections.Generic;
using NpgsqlTypes;

namespace S2CDataMigration.Models
{
    public partial class BillingItems
    {
        public BillingItems()
        {
            AmaFees = new HashSet<AmaFees>();
            BillingItemsProcedures = new HashSet<BillingItemsProcedures>();
            BillingSetItems = new HashSet<BillingSetItems>();
            DvaFees = new HashSet<DvaFees>();
            Fees = new HashSet<Fees>();
            HealthFundFees = new HashSet<HealthFundFees>();
            InverseAmaBillingItem = new HashSet<BillingItems>();
            InvoiceItems = new HashSet<InvoiceItems>();
            MbsFees = new HashSet<MbsFees>();
            PrivateMbsFees = new HashSet<PrivateMbsFees>();
        }

        public Guid Id { get; set; }
        public Guid? PracticeId { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool GstIncluded { get; set; }
        public decimal? PrivateFee { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public NpgsqlTsVector Tsv { get; set; }
        public Guid? AmaBillingItemId { get; set; }
        public string Category { get; set; }
        public string DiagnosticItemType { get; set; }

        public virtual BillingItems AmaBillingItem { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ICollection<AmaFees> AmaFees { get; set; }
        public virtual ICollection<BillingItemsProcedures> BillingItemsProcedures { get; set; }
        public virtual ICollection<BillingSetItems> BillingSetItems { get; set; }
        public virtual ICollection<DvaFees> DvaFees { get; set; }
        public virtual ICollection<Fees> Fees { get; set; }
        public virtual ICollection<HealthFundFees> HealthFundFees { get; set; }
        public virtual ICollection<BillingItems> InverseAmaBillingItem { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
        public virtual ICollection<MbsFees> MbsFees { get; set; }
        public virtual ICollection<PrivateMbsFees> PrivateMbsFees { get; set; }
    }
}
