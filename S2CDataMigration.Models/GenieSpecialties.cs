using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class GenieSpecialties
    {
        public GenieSpecialties()
        {
            Contacts = new HashSet<Contacts>();
            PracticesSpecialties = new HashSet<PracticesSpecialties>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<PracticesSpecialties> PracticesSpecialties { get; set; }
    }
}
