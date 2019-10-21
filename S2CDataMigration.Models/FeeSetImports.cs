using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class FeeSetImports
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public Guid FeeSetId { get; set; }
        public Guid? PracticeId { get; set; }
        public string SessionId { get; set; }
        public string ImportFileName { get; set; }
        public string ImportContentType { get; set; }
        public int? ImportFileSize { get; set; }
        public DateTime? ImportUpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual FeeSets FeeSet { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
