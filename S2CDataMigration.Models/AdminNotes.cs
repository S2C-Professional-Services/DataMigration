using System;
using System.Collections.Generic;
using NpgsqlTypes;

namespace S2CDataMigration.Models
{
    public partial class AdminNotes
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Pinned { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public NpgsqlTsVector Tsv { get; set; }
        public bool Flagged { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
