using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class RequestLabProviders
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid RequestLabId { get; set; }
        public Guid UserId { get; set; }
        public string DoctorCode { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual RequestLabs RequestLab { get; set; }
        public virtual Users User { get; set; }
    }
}
