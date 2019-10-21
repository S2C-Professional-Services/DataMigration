using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class DiagnosticRequestCcs
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid DiagnosticRequestId { get; set; }
        public Guid ContactId { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Contacts Contact { get; set; }
        public virtual DiagnosticRequests DiagnosticRequest { get; set; }
        public virtual Practices Practice { get; set; }
    }
}
