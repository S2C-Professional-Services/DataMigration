using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ObstetricsChildren
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PregnancyId { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
        public decimal? Weight { get; set; }
        public string Sex { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Apgar1 { get; set; }
        public int? Apgar5 { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ObstetricsPregnancies Pregnancy { get; set; }
    }
}
