using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class RequestLabs
    {
        public RequestLabs()
        {
            DiagnosticRequests = new HashSet<DiagnosticRequests>();
            RequestLabProviders = new HashSet<RequestLabProviders>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string Name { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ContactNumber { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ICollection<DiagnosticRequests> DiagnosticRequests { get; set; }
        public virtual ICollection<RequestLabProviders> RequestLabProviders { get; set; }
    }
}
