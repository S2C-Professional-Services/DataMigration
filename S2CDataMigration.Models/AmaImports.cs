using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class AmaImports
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid UserId { get; set; }
        public string SessionId { get; set; }
        public string ImportFileFileName { get; set; }
        public string ImportFileContentType { get; set; }
        public int? ImportFileFileSize { get; set; }
        public DateTime? ImportFileUpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual Users User { get; set; }
    }
}
