using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class MbsFees
    {
        public Guid Id { get; set; }
        public Guid MbsImportId { get; set; }
        public Guid MbsBillingItemId { get; set; }
        public DateTime StartsOn { get; set; }
        public DateTime? EndsOn { get; set; }
        public string Group { get; set; }
        public string Subgroup { get; set; }
        public string BenefitType { get; set; }
        public string FeeType { get; set; }
        public decimal ScheduleFee { get; set; }
        public decimal Benefit75 { get; set; }
        public decimal Benefit85 { get; set; }
        public decimal Benefit100 { get; set; }
        public bool Assist { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual BillingItems MbsBillingItem { get; set; }
        public virtual MbsImports MbsImport { get; set; }
    }
}
