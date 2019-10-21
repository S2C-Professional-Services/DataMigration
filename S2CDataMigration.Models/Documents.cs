using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Documents
    {
        public Documents()
        {
            DocumentContents = new HashSet<DocumentContents>();
            PatientReportLinks = new HashSet<PatientReportLinks>();
            ReportLinkSuggestions = new HashSet<ReportLinkSuggestions>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string DocumentType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? CollectedOn { get; set; }
        public string Addressee { get; set; }
        public string Type { get; set; }
        public string Result { get; set; }
        public DateTime? BornOn { get; set; }
        public string MedicareNumber { get; set; }
        public string MessageUuid { get; set; }
        public string ReferringProvider { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public string Description { get; set; }
        public string ResultStatus { get; set; }
        public string MessageId { get; set; }
        public string[] AckUuids { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public DateTime? SetOn { get; set; }
        public Guid? RestrictedById { get; set; }
        public DateTime? RestrictedAt { get; set; }
        public string LaboratoryName { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual Users RestrictedBy { get; set; }
        public virtual ICollection<DocumentContents> DocumentContents { get; set; }
        public virtual ICollection<PatientReportLinks> PatientReportLinks { get; set; }
        public virtual ICollection<ReportLinkSuggestions> ReportLinkSuggestions { get; set; }
    }
}
