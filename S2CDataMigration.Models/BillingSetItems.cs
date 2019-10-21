using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class BillingSetItems
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid BillingSetId { get; set; }
        public Guid BillingItemId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual BillingItems BillingItem { get; set; }
        public virtual BillingSets BillingSet { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
