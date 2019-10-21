using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class PracticesSpecialties
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid SpecialtyId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual GenieSpecialties Specialty { get; set; }
    }
}
