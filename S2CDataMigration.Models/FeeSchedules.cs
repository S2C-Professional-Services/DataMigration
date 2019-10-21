using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class FeeSchedules
    {
        public FeeSchedules()
        {
            FeeSets = new HashSet<FeeSets>();
            HealthFundDetails = new HashSet<HealthFundDetails>();
            HealthFunds = new HashSet<HealthFunds>();
            Invoices = new HashSet<Invoices>();
        }

        public Guid Id { get; set; }
        public string Type { get; set; }
        public Guid? PracticeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Data { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ICollection<FeeSets> FeeSets { get; set; }
        public virtual ICollection<HealthFundDetails> HealthFundDetails { get; set; }
        public virtual ICollection<HealthFunds> HealthFunds { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
