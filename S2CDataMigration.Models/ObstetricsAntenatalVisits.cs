using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ObstetricsAntenatalVisits
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PregnancyId { get; set; }
        public Guid ProviderId { get; set; }
        public DateTime VisitedOn { get; set; }
        public decimal? Weight { get; set; }
        public string Oedema { get; set; }
        public string Urine { get; set; }
        public string Presentation { get; set; }
        public decimal? FundalHeight { get; set; }
        public string BloodPressure { get; set; }
        public string Station { get; set; }
        public string FetalMovement { get; set; }
        public string FetalHeartRate { get; set; }
        public string LiquorVolume { get; set; }
        public string Comments { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? LocalId { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ObstetricsPregnancies Pregnancy { get; set; }
        public virtual Users Provider { get; set; }
    }
}
