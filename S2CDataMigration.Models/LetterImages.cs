using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class LetterImages
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string ContentFileName { get; set; }
        public string ContentContentType { get; set; }
        public int? ContentFileSize { get; set; }
        public DateTime? ContentUpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ContentFingerprint { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Practices Practice { get; set; }
    }
}
