using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class DocumentContents
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid DocumentId { get; set; }
        public string ContentFileName { get; set; }
        public string ContentContentType { get; set; }
        public int? ContentFileSize { get; set; }
        public DateTime? ContentUpdatedAt { get; set; }
        public string Format { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Type { get; set; }

        public virtual Documents Document { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
