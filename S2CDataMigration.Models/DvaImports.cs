using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class DvaImports
    {
        public DvaImports()
        {
            DvaFees = new HashSet<DvaFees>();
        }

        public Guid Id { get; set; }
        public string Filename { get; set; }
        public DateTime EffectiveOn { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<DvaFees> DvaFees { get; set; }
    }
}
