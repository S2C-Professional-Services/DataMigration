using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class States
    {
        public States()
        {
            Addresses = new HashSet<Addresses>();
            FeeSets = new HashSet<FeeSets>();
            HealthFundImports = new HashSet<HealthFundImports>();
            Practices = new HashSet<Practices>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<FeeSets> FeeSets { get; set; }
        public virtual ICollection<HealthFundImports> HealthFundImports { get; set; }
        public virtual ICollection<Practices> Practices { get; set; }
    }
}
