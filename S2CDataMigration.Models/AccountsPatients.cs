using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class AccountsPatients
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid PatientId { get; set; }
        public Guid PracticeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool Primary { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Patients Patient { get; set; }
    }
}
