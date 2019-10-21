using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class AmaFees
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid MbsBillingItemId { get; set; }
        public decimal? Fee { get; set; }
        public string Code { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual BillingItems MbsBillingItem { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
