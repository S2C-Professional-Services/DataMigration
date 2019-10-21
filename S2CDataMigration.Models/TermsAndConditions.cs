using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class TermsAndConditions
    {
        public TermsAndConditions()
        {
            TermsAcceptances = new HashSet<TermsAcceptances>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<TermsAcceptances> TermsAcceptances { get; set; }
    }
}
