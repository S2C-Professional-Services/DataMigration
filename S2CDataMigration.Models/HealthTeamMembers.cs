using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class HealthTeamMembers
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid ContactId { get; set; }
        public bool NominatedGp { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Contacts Contact { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
