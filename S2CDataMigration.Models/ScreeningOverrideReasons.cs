using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ScreeningOverrideReasons
    {
        public ScreeningOverrideReasons()
        {
            ScreeningOverrides = new HashSet<ScreeningOverrides>();
        }

        public Guid Id { get; set; }
        public string Text { get; set; }
        public int Position { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<ScreeningOverrides> ScreeningOverrides { get; set; }
    }
}
