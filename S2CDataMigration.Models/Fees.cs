using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Fees
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public Guid? PracticeId { get; set; }
        public Guid BillingItemId { get; set; }
        public Guid FeeSetId { get; set; }
        public DateTime StartsOn { get; set; }
        public string Data { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual BillingItems BillingItem { get; set; }
        public virtual FeeSets FeeSet { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
