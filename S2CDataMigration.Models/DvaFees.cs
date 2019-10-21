using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class DvaFees
    {
        public Guid Id { get; set; }
        public Guid DvaImportId { get; set; }
        public Guid MbsBillingItemId { get; set; }
        public decimal LmoFee { get; set; }
        public decimal InpatientFee { get; set; }
        public decimal OutpatientFee { get; set; }
        public bool Derived { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime StartsOn { get; set; }

        public virtual DvaImports DvaImport { get; set; }
        public virtual BillingItems MbsBillingItem { get; set; }
    }
}
