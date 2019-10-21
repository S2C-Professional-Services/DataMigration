using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class BillingSets
    {
        public BillingSets()
        {
            BillingSetItems = new HashSet<BillingSetItems>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ICollection<BillingSetItems> BillingSetItems { get; set; }
    }
}
