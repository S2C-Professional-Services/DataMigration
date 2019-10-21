using System;
using System.Collections.Generic;
using System.Net;

namespace S2CDataMigration.Models
{
    public partial class Users
    {
        public Users()
        {
            AmaImports = new HashSet<AmaImports>();
            AppErrors = new HashSet<AppErrors>();
            ClinicalInteractionSettings = new HashSet<ClinicalInteractionSettings>();
            ConsultNotes = new HashSet<ConsultNotes>();
            DiagnosticRequests = new HashSet<DiagnosticRequests>();
            Documents = new HashSet<Documents>();
            Events = new HashSet<Events>();
            HealthFundDetails = new HashSet<HealthFundDetails>();
            Invoices = new HashSet<Invoices>();
            LettersRestrictedBy = new HashSet<Letters>();
            LettersSender = new HashSet<Letters>();
            ObstetricsAntenatalVisits = new HashSet<ObstetricsAntenatalVisits>();
            ObstetricsPregnancies = new HashSet<ObstetricsPregnancies>();
            Prescriptions = new HashSet<Prescriptions>();
            ProceduresRestrictedBy = new HashSet<Procedures>();
            ProceduresUser = new HashSet<Procedures>();
            RequestLabProviders = new HashSet<RequestLabProviders>();
            SitesOfService = new HashSet<SitesOfService>();
            TermsAcceptances = new HashSet<TermsAcceptances>();
            ToDoComments = new HashSet<ToDoComments>();
            ToDos = new HashSet<ToDos>();
            Txns = new HashSet<Txns>();
            UsersToDos = new HashSet<UsersToDos>();
        }

        public Guid Id { get; set; }
        public Guid? PracticeId { get; set; }
        public string Type { get; set; }
        public IPAddress CurrentSignInIp { get; set; }
        public IPAddress LastSignInIp { get; set; }
        public string ConfirmationToken { get; set; }
        public string ResetPasswordToken { get; set; }
        public string UnlockToken { get; set; }
        public string Email { get; set; }
        public string UnconfirmedEmail { get; set; }
        public string EncryptedPassword { get; set; }
        public int SignInCount { get; set; }
        public int FailedAttempts { get; set; }
        public bool Inactive { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string InvitationToken { get; set; }
        public DateTime? InvitationCreatedAt { get; set; }
        public DateTime? InvitationSentAt { get; set; }
        public DateTime? InvitationAcceptedAt { get; set; }
        public int? InvitationLimit { get; set; }
        public string InvitedByType { get; set; }
        public Guid? InvitedById { get; set; }
        public int? InvitationsCount { get; set; }
        public DateTime? ResetPasswordSentAt { get; set; }
        public DateTime? RememberCreatedAt { get; set; }
        public DateTime? CurrentSignInAt { get; set; }
        public DateTime? LastSignInAt { get; set; }
        public DateTime? ConfirmationSentAt { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public DateTime? LockedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string EncryptedOtpSecret { get; set; }
        public string EncryptedOtpSecretIv { get; set; }
        public string EncryptedOtpSecretSalt { get; set; }
        public int? ConsumedTimestep { get; set; }
        public bool OtpRequiredForLogin { get; set; }
        public string[] OtpBackupCodes { get; set; }
        public bool ShowInAppts { get; set; }
        public int? TimeoutDuration { get; set; }
        public Guid? RoleId { get; set; }
        public string Abn { get; set; }
        public string PrescriberNumber { get; set; }
        public string PrescriberType { get; set; }
        public bool ClinicalInteractionsEnabled { get; set; }
        public bool AllowNotifications { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual Roles Role { get; set; }
        public virtual AuthorityPrescriptionNumberGenerators AuthorityPrescriptionNumberGenerators { get; set; }
        public virtual ICollection<AmaImports> AmaImports { get; set; }
        public virtual ICollection<AppErrors> AppErrors { get; set; }
        public virtual ICollection<ClinicalInteractionSettings> ClinicalInteractionSettings { get; set; }
        public virtual ICollection<ConsultNotes> ConsultNotes { get; set; }
        public virtual ICollection<DiagnosticRequests> DiagnosticRequests { get; set; }
        public virtual ICollection<Documents> Documents { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<HealthFundDetails> HealthFundDetails { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<Letters> LettersRestrictedBy { get; set; }
        public virtual ICollection<Letters> LettersSender { get; set; }
        public virtual ICollection<ObstetricsAntenatalVisits> ObstetricsAntenatalVisits { get; set; }
        public virtual ICollection<ObstetricsPregnancies> ObstetricsPregnancies { get; set; }
        public virtual ICollection<Prescriptions> Prescriptions { get; set; }
        public virtual ICollection<Procedures> ProceduresRestrictedBy { get; set; }
        public virtual ICollection<Procedures> ProceduresUser { get; set; }
        public virtual ICollection<RequestLabProviders> RequestLabProviders { get; set; }
        public virtual ICollection<SitesOfService> SitesOfService { get; set; }
        public virtual ICollection<TermsAcceptances> TermsAcceptances { get; set; }
        public virtual ICollection<ToDoComments> ToDoComments { get; set; }
        public virtual ICollection<ToDos> ToDos { get; set; }
        public virtual ICollection<Txns> Txns { get; set; }
        public virtual ICollection<UsersToDos> UsersToDos { get; set; }
    }
}
