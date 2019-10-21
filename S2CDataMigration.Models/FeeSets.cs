using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class FeeSets
    {
        public FeeSets()
        {
            FeeSetImports = new HashSet<FeeSetImports>();
            Fees = new HashSet<Fees>();
        }

        public Guid Id { get; set; }
        public string Type { get; set; }
        public Guid? PracticeId { get; set; }
        public Guid FeeScheduleId { get; set; }
        public DateTime EffectiveOn { get; set; }
        public Guid? StateId { get; set; }
        public string Data { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual FeeSchedules FeeSchedule { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual States State { get; set; }
        public virtual ICollection<FeeSetImports> FeeSetImports { get; set; }
        public virtual ICollection<Fees> Fees { get; set; }
    }
}
