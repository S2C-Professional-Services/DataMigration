using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ReasonsForEncounter
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string Reason { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
    }
}
