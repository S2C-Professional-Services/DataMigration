using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class MbsImports
    {
        public MbsImports()
        {
            MbsFees = new HashSet<MbsFees>();
        }

        public Guid Id { get; set; }
        public string Filename { get; set; }
        public DateTime EffectiveOn { get; set; }
        public decimal? AssistThreshold { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<MbsFees> MbsFees { get; set; }
    }
}
