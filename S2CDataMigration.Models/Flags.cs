using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Flags
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string SubjectType { get; set; }
        public Guid SubjectId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime? StartsAt { get; set; }
        public DateTime? EndsAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
    }
}
