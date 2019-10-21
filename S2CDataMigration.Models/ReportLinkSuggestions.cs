using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ReportLinkSuggestions
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid DocumentId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Documents Document { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
