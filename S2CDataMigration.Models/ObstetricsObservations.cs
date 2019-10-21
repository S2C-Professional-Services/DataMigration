using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ObstetricsObservations
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PregnancyId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime? OccurredOn { get; set; }
        public string Result { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? LocalId { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ObstetricsPregnancies Pregnancy { get; set; }
    }
}
