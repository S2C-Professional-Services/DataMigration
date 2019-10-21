using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ScreeningInteractions
    {
        public ScreeningInteractions()
        {
            ScreeningOverrides = new HashSet<ScreeningOverrides>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public Guid PracticeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Type { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ICollection<ScreeningOverrides> ScreeningOverrides { get; set; }
    }
}
