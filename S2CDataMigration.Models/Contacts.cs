using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Contacts
    {
        public Contacts()
        {
            DiagnosticRequestCcs = new HashSet<DiagnosticRequestCcs>();
            HealthTeamMembers = new HashSet<HealthTeamMembers>();
            InvoiceItems = new HashSet<InvoiceItems>();
            Invoices = new HashSet<Invoices>();
            ObstetricsPregnancies = new HashSet<ObstetricsPregnancies>();
            ProceduresAnaesthetistContact = new HashSet<Procedures>();
            ProceduresAssistantContact = new HashSet<Procedures>();
            ProceduresBusinessContact = new HashSet<Procedures>();
            ProceduresPaediatricianContact = new HashSet<Procedures>();
            Referrals = new HashSet<Referrals>();
            ThirdPartyClaimsEmployer = new HashSet<ThirdPartyClaims>();
            ThirdPartyClaimsInsurer = new HashSet<ThirdPartyClaims>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? AddressId { get; set; }
        public Guid? HealthFundId { get; set; }
        public Guid? GenieSpecialtyId { get; set; }
        public string Type { get; set; }
        public bool Assistant { get; set; }
        public bool BusinessPerformsProcedure { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ContactMethod { get; set; }
        public string ProviderNumber { get; set; }
        public string BusinessName { get; set; }
        public string Healthlink { get; set; }
        public DateTime? BornOn { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Argus { get; set; }
        public bool IssueInvoice { get; set; }
        public Guid? BillingAddressId { get; set; }
        public Guid? FeeScheduleId { get; set; }
        public string EntityType { get; set; }
        public string MedicalObjects { get; set; }
        public bool ApplyGst { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual Addresses BillingAddress { get; set; }
        public virtual GenieSpecialties GenieSpecialty { get; set; }
        public virtual HealthFunds HealthFund { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ICollection<DiagnosticRequestCcs> DiagnosticRequestCcs { get; set; }
        public virtual ICollection<HealthTeamMembers> HealthTeamMembers { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<ObstetricsPregnancies> ObstetricsPregnancies { get; set; }
        public virtual ICollection<Procedures> ProceduresAnaesthetistContact { get; set; }
        public virtual ICollection<Procedures> ProceduresAssistantContact { get; set; }
        public virtual ICollection<Procedures> ProceduresBusinessContact { get; set; }
        public virtual ICollection<Procedures> ProceduresPaediatricianContact { get; set; }
        public virtual ICollection<Referrals> Referrals { get; set; }
        public virtual ICollection<ThirdPartyClaims> ThirdPartyClaimsEmployer { get; set; }
        public virtual ICollection<ThirdPartyClaims> ThirdPartyClaimsInsurer { get; set; }
    }
}
