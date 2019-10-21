using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Referrals
    {
        public Referrals()
        {
            Invoices = new HashSet<Invoices>();
            PatientReportLinks = new HashSet<PatientReportLinks>();
            Vouchers = new HashSet<Vouchers>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid ReferringDoctorId { get; set; }
        public DateTime? IssuedOn { get; set; }
        public DateTime? StartedOn { get; set; }
        public bool Indefinite { get; set; }
        public int? Duration { get; set; }
        public string UploadFile { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Contacts ReferringDoctor { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<PatientReportLinks> PatientReportLinks { get; set; }
        public virtual ICollection<Vouchers> Vouchers { get; set; }
    }
}
