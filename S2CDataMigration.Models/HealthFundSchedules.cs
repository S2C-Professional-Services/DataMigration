using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class HealthFundSchedules
    {
        public HealthFundSchedules()
        {
            HealthFundImports = new HashSet<HealthFundImports>();
        }

        public Guid Id { get; set; }
        public Guid? PracticeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal? MbsMultiplier { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ICollection<HealthFundImports> HealthFundImports { get; set; }
    }
}
