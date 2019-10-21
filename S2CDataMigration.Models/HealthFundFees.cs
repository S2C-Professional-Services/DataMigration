using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class HealthFundFees
    {
        public Guid Id { get; set; }
        public Guid HealthFundImportId { get; set; }
        public Guid BillingItemId { get; set; }
        public decimal? ScheduleFee { get; set; }
        public decimal? SchedulePercentage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual BillingItems BillingItem { get; set; }
        public virtual HealthFundImports HealthFundImport { get; set; }
    }
}
