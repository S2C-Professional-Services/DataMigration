using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            ContactsAddress = new HashSet<Contacts>();
            ContactsBillingAddress = new HashSet<Contacts>();
            PatientsPostalAddress = new HashSet<Patients>();
            PatientsResidentialAddress = new HashSet<Patients>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? StateId { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual States State { get; set; }
        public virtual ICollection<Contacts> ContactsAddress { get; set; }
        public virtual ICollection<Contacts> ContactsBillingAddress { get; set; }
        public virtual ICollection<Patients> PatientsPostalAddress { get; set; }
        public virtual ICollection<Patients> PatientsResidentialAddress { get; set; }
    }
}
