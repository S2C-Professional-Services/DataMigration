using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class EmergencyContacts
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }
        public bool NextOfKin { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
