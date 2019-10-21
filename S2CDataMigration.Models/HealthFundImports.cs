using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class HealthFundImports
    {
        public HealthFundImports()
        {
            HealthFundFees = new HashSet<HealthFundFees>();
        }

        public Guid Id { get; set; }
        public Guid HealthFundScheduleId { get; set; }
        public Guid? StateId { get; set; }
        public DateTime? EffectiveOn { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual HealthFundSchedules HealthFundSchedule { get; set; }
        public virtual States State { get; set; }
        public virtual ICollection<HealthFundFees> HealthFundFees { get; set; }
    }
}
