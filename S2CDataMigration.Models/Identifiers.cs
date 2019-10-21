using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Identifiers
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string Identifier { get; set; }
        public string Service { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
    }
}
