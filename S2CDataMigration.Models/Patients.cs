using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Patients
    {
        public Patients()
        {
            AccountsPatients = new HashSet<AccountsPatients>();
            AdminNotes = new HashSet<AdminNotes>();
            AdverseReactionVersions = new HashSet<AdverseReactionVersions>();
            AdverseReactions = new HashSet<AdverseReactions>();
            ConsultNoteVersions = new HashSet<ConsultNoteVersions>();
            ConsultNotes = new HashSet<ConsultNotes>();
            Diagnoses = new HashSet<Diagnoses>();
            DiagnosisVersions = new HashSet<DiagnosisVersions>();
            DiagnosticRequests = new HashSet<DiagnosticRequests>();
            EmergencyContacts = new HashSet<EmergencyContacts>();
            Events = new HashSet<Events>();
            HealthTeamMembers = new HashSet<HealthTeamMembers>();
            Invoices = new HashSet<Invoices>();
            LetterVersions = new HashSet<LetterVersions>();
            Letters = new HashSet<Letters>();
            MedicationVersions = new HashSet<MedicationVersions>();
            Medications = new HashSet<Medications>();
            ObstetricsPregnancies = new HashSet<ObstetricsPregnancies>();
            PastProcedureVersions = new HashSet<PastProcedureVersions>();
            PastProcedures = new HashSet<PastProcedures>();
            PatientReportLinkVersions = new HashSet<PatientReportLinkVersions>();
            PatientReportLinks = new HashSet<PatientReportLinks>();
            PrescriptionVersions = new HashSet<PrescriptionVersions>();
            Prescriptions = new HashSet<Prescriptions>();
            ProcedureVersions = new HashSet<ProcedureVersions>();
            Procedures = new HashSet<Procedures>();
            Referrals = new HashSet<Referrals>();
            ReportLinkSuggestions = new HashSet<ReportLinkSuggestions>();
            ThirdPartyClaims = new HashSet<ThirdPartyClaims>();
            ToDos = new HashSet<ToDos>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? ResidentialAddressId { get; set; }
        public Guid? PostalAddressId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public string MaidenName { get; set; }
        public string Gender { get; set; }
        public DateTime? BornOn { get; set; }
        public DateTime? DiedOn { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Occupation { get; set; }
        public string ChartNumber { get; set; }
        public int IndigenousStatus { get; set; }
        public bool Inactive { get; set; }
        public bool Deceased { get; set; }
        public bool? UseResidentialAddress { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? SmsDisabled { get; set; }
        public bool EmailDisabled { get; set; }
        public string EmailAttachmentPassword { get; set; }

        public virtual Addresses PostalAddress { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Addresses ResidentialAddress { get; set; }
        public virtual ICollection<AccountsPatients> AccountsPatients { get; set; }
        public virtual ICollection<AdminNotes> AdminNotes { get; set; }
        public virtual ICollection<AdverseReactionVersions> AdverseReactionVersions { get; set; }
        public virtual ICollection<AdverseReactions> AdverseReactions { get; set; }
        public virtual ICollection<ConsultNoteVersions> ConsultNoteVersions { get; set; }
        public virtual ICollection<ConsultNotes> ConsultNotes { get; set; }
        public virtual ICollection<Diagnoses> Diagnoses { get; set; }
        public virtual ICollection<DiagnosisVersions> DiagnosisVersions { get; set; }
        public virtual ICollection<DiagnosticRequests> DiagnosticRequests { get; set; }
        public virtual ICollection<EmergencyContacts> EmergencyContacts { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<HealthTeamMembers> HealthTeamMembers { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<LetterVersions> LetterVersions { get; set; }
        public virtual ICollection<Letters> Letters { get; set; }
        public virtual ICollection<MedicationVersions> MedicationVersions { get; set; }
        public virtual ICollection<Medications> Medications { get; set; }
        public virtual ICollection<ObstetricsPregnancies> ObstetricsPregnancies { get; set; }
        public virtual ICollection<PastProcedureVersions> PastProcedureVersions { get; set; }
        public virtual ICollection<PastProcedures> PastProcedures { get; set; }
        public virtual ICollection<PatientReportLinkVersions> PatientReportLinkVersions { get; set; }
        public virtual ICollection<PatientReportLinks> PatientReportLinks { get; set; }
        public virtual ICollection<PrescriptionVersions> PrescriptionVersions { get; set; }
        public virtual ICollection<Prescriptions> Prescriptions { get; set; }
        public virtual ICollection<ProcedureVersions> ProcedureVersions { get; set; }
        public virtual ICollection<Procedures> Procedures { get; set; }
        public virtual ICollection<Referrals> Referrals { get; set; }
        public virtual ICollection<ReportLinkSuggestions> ReportLinkSuggestions { get; set; }
        public virtual ICollection<ThirdPartyClaims> ThirdPartyClaims { get; set; }
        public virtual ICollection<ToDos> ToDos { get; set; }
    }
}
