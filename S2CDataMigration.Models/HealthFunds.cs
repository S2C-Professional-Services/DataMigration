using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class HealthFunds
    {
        public HealthFunds()
        {
            Contacts = new HashSet<Contacts>();
            HealthFundDetails = new HashSet<HealthFundDetails>();
            Invoices = new HashSet<Invoices>();
        }

        public Guid Id { get; set; }
        public Guid? PracticeId { get; set; }
        public Guid? HealthFundScheduleId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public bool? Era { get; set; }
        public bool? Opv { get; set; }
        public bool? ImcAgreements { get; set; }
        public bool? ImcSchemes { get; set; }
        public bool? ImcMedicareBenefits { get; set; }
        public bool? ImcPatientClaims { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Ahsa { get; set; }

        public virtual FeeSchedules HealthFundSchedule { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<HealthFundDetails> HealthFundDetails { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
