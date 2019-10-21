using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Recipients
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid LetterId { get; set; }
        public Guid ContactableId { get; set; }
        public string Type { get; set; }
        public string ContactMethod { get; set; }
        public string MessageId { get; set; }
        public DateTime? PrintedAt { get; set; }
        public DateTime? SentAt { get; set; }
        public DateTime? AckAt { get; set; }
        public string[] AckError { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string AckedBy { get; set; }
        public string MessageUuid { get; set; }
        public string ContactableType { get; set; }
        public string[] AckUuids { get; set; }
        public string AckType { get; set; }

        public virtual Letters Letter { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
