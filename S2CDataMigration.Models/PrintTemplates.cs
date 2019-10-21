using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class PrintTemplates
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Type { get; set; }
        public Guid? LetterheadId { get; set; }
        public string TemplateConfig { get; set; }

        public virtual Practices Practice { get; set; }
    }
}
