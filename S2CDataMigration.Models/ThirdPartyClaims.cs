using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ThirdPartyClaims
    {
        public ThirdPartyClaims()
        {
            Invoices = new HashSet<Invoices>();
            Procedures = new HashSet<Procedures>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public string Status { get; set; }
        public Guid? InsurerId { get; set; }
        public string ClaimNumber { get; set; }
        public string Injury { get; set; }
        public DateTime? InjuredOn { get; set; }
        public string CaseManager { get; set; }
        public Guid? EmployerId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public string CaseManagerPhone { get; set; }
        public string CaseManagerEmail { get; set; }
        public string CaseManagerFax { get; set; }

        public virtual Contacts Employer { get; set; }
        public virtual Contacts Insurer { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<Procedures> Procedures { get; set; }
    }
}
