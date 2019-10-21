using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Practices
    {
        public Practices()
        {
            Accounts = new HashSet<Accounts>();
            Addresses = new HashSet<Addresses>();
            AdminNotes = new HashSet<AdminNotes>();
            AdverseReactions = new HashSet<AdverseReactions>();
            AmaFees = new HashSet<AmaFees>();
            AmaImports = new HashSet<AmaImports>();
            AppErrors = new HashSet<AppErrors>();
            AppointmentTypes = new HashSet<AppointmentTypes>();
            AuthorityPrescriptionNumberGenerators = new HashSet<AuthorityPrescriptionNumberGenerators>();
            BillingItems = new HashSet<BillingItems>();
            BillingSetItems = new HashSet<BillingSetItems>();
            BillingSets = new HashSet<BillingSets>();
            Cards = new HashSet<Cards>();
            ClaimInvoiceNotes = new HashSet<ClaimInvoiceNotes>();
            Claims = new HashSet<Claims>();
            ClinicalInteractionSettings = new HashSet<ClinicalInteractionSettings>();
            ConsultNotes = new HashSet<ConsultNotes>();
            Contacts = new HashSet<Contacts>();
            CustomMedications = new HashSet<CustomMedications>();
            Diagnoses = new HashSet<Diagnoses>();
            DiagnosticRequestCcs = new HashSet<DiagnosticRequestCcs>();
            DiagnosticRequests = new HashSet<DiagnosticRequests>();
            DocumentContents = new HashSet<DocumentContents>();
            Documents = new HashSet<Documents>();
            EmergencyContacts = new HashSet<EmergencyContacts>();
            Events = new HashSet<Events>();
            FeeSchedules = new HashSet<FeeSchedules>();
            FeeSetImports = new HashSet<FeeSetImports>();
            FeeSets = new HashSet<FeeSets>();
            Fees = new HashSet<Fees>();
            Flags = new HashSet<Flags>();
            HealthFundDetails = new HashSet<HealthFundDetails>();
            HealthFundSchedules = new HashSet<HealthFundSchedules>();
            HealthFunds = new HashSet<HealthFunds>();
            HealthTeamMembers = new HashSet<HealthTeamMembers>();
            Identifiers = new HashSet<Identifiers>();
            InvoiceItemTxns = new HashSet<InvoiceItemTxns>();
            InvoiceItems = new HashSet<InvoiceItems>();
            Invoices = new HashSet<Invoices>();
            LetterImages = new HashSet<LetterImages>();
            Letters = new HashSet<Letters>();
            Medications = new HashSet<Medications>();
            ObstetricsAntenatalVisits = new HashSet<ObstetricsAntenatalVisits>();
            ObstetricsChildren = new HashSet<ObstetricsChildren>();
            ObstetricsInvestigations = new HashSet<ObstetricsInvestigations>();
            ObstetricsObservations = new HashSet<ObstetricsObservations>();
            ObstetricsPostnatalVisits = new HashSet<ObstetricsPostnatalVisits>();
            ObstetricsPregnancies = new HashSet<ObstetricsPregnancies>();
            PastProcedures = new HashSet<PastProcedures>();
            PatientReportLinks = new HashSet<PatientReportLinks>();
            Patients = new HashSet<Patients>();
            PracticesSpecialties = new HashSet<PracticesSpecialties>();
            Preferences = new HashSet<Preferences>();
            PrescriptionAuthorities = new HashSet<PrescriptionAuthorities>();
            PrescriptionMedications = new HashSet<PrescriptionMedications>();
            Prescriptions = new HashSet<Prescriptions>();
            PrintTemplates = new HashSet<PrintTemplates>();
            PrivateMbsFees = new HashSet<PrivateMbsFees>();
            ProcedureCategories = new HashSet<ProcedureCategories>();
            ProcedureReferences = new HashSet<ProcedureReferences>();
            Procedures = new HashSet<Procedures>();
            ReasonsForEncounter = new HashSet<ReasonsForEncounter>();
            Recipients = new HashSet<Recipients>();
            Referrals = new HashSet<Referrals>();
            ReportLinkSuggestions = new HashSet<ReportLinkSuggestions>();
            RequestLabProviders = new HashSet<RequestLabProviders>();
            RequestLabs = new HashSet<RequestLabs>();
            RolePermissions = new HashSet<RolePermissions>();
            Roles = new HashSet<Roles>();
            ScreeningInteractions = new HashSet<ScreeningInteractions>();
            ScreeningOverrides = new HashSet<ScreeningOverrides>();
            Services = new HashSet<Services>();
            SitesOfService = new HashSet<SitesOfService>();
            TermsAcceptances = new HashSet<TermsAcceptances>();
            ThirdPartyClaims = new HashSet<ThirdPartyClaims>();
            ToDoComments = new HashSet<ToDoComments>();
            ToDos = new HashSet<ToDos>();
            Txns = new HashSet<Txns>();
            Users = new HashSet<Users>();
            UsersToDos = new HashSet<UsersToDos>();
            Vouchers = new HashSet<Vouchers>();
        }

        public Guid Id { get; set; }
        public Guid StateId { get; set; }
        public string Name { get; set; }
        public string Timezone { get; set; }
        public string CurrentSoftware { get; set; }
        public string PracticeType { get; set; }
        public string HealthlinkIdentifier { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Abn { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string LocationCode { get; set; }
        public Guid? MedicareAccountId { get; set; }
        public Guid? DvaAccountId { get; set; }
        public int SubscriptionCount { get; set; }
        public string BillingAgentId { get; set; }
        public int Modules { get; set; }
        public bool SmsAlerts { get; set; }
        public bool SmsEnabled { get; set; }
        public string MedicalObjectsIdentifier { get; set; }
        public string CapricornUrl { get; set; }
        public string MedicalObjectsDeliveryReportUrl { get; set; }
        public string RtacNumber { get; set; }
        public bool EmailEnabled { get; set; }
        public string EmailReplyAddress { get; set; }
        public DateTime? SmsPlatformServiceEnabledAt { get; set; }

        public virtual Accounts DvaAccount { get; set; }
        public virtual Accounts MedicareAccount { get; set; }
        public virtual States State { get; set; }
        public virtual ICollection<Accounts> Accounts { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<AdminNotes> AdminNotes { get; set; }
        public virtual ICollection<AdverseReactions> AdverseReactions { get; set; }
        public virtual ICollection<AmaFees> AmaFees { get; set; }
        public virtual ICollection<AmaImports> AmaImports { get; set; }
        public virtual ICollection<AppErrors> AppErrors { get; set; }
        public virtual ICollection<AppointmentTypes> AppointmentTypes { get; set; }
        public virtual ICollection<AuthorityPrescriptionNumberGenerators> AuthorityPrescriptionNumberGenerators { get; set; }
        public virtual ICollection<BillingItems> BillingItems { get; set; }
        public virtual ICollection<BillingSetItems> BillingSetItems { get; set; }
        public virtual ICollection<BillingSets> BillingSets { get; set; }
        public virtual ICollection<Cards> Cards { get; set; }
        public virtual ICollection<ClaimInvoiceNotes> ClaimInvoiceNotes { get; set; }
        public virtual ICollection<Claims> Claims { get; set; }
        public virtual ICollection<ClinicalInteractionSettings> ClinicalInteractionSettings { get; set; }
        public virtual ICollection<ConsultNotes> ConsultNotes { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<CustomMedications> CustomMedications { get; set; }
        public virtual ICollection<Diagnoses> Diagnoses { get; set; }
        public virtual ICollection<DiagnosticRequestCcs> DiagnosticRequestCcs { get; set; }
        public virtual ICollection<DiagnosticRequests> DiagnosticRequests { get; set; }
        public virtual ICollection<DocumentContents> DocumentContents { get; set; }
        public virtual ICollection<Documents> Documents { get; set; }
        public virtual ICollection<EmergencyContacts> EmergencyContacts { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<FeeSchedules> FeeSchedules { get; set; }
        public virtual ICollection<FeeSetImports> FeeSetImports { get; set; }
        public virtual ICollection<FeeSets> FeeSets { get; set; }
        public virtual ICollection<Fees> Fees { get; set; }
        public virtual ICollection<Flags> Flags { get; set; }
        public virtual ICollection<HealthFundDetails> HealthFundDetails { get; set; }
        public virtual ICollection<HealthFundSchedules> HealthFundSchedules { get; set; }
        public virtual ICollection<HealthFunds> HealthFunds { get; set; }
        public virtual ICollection<HealthTeamMembers> HealthTeamMembers { get; set; }
        public virtual ICollection<Identifiers> Identifiers { get; set; }
        public virtual ICollection<InvoiceItemTxns> InvoiceItemTxns { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<LetterImages> LetterImages { get; set; }
        public virtual ICollection<Letters> Letters { get; set; }
        public virtual ICollection<Medications> Medications { get; set; }
        public virtual ICollection<ObstetricsAntenatalVisits> ObstetricsAntenatalVisits { get; set; }
        public virtual ICollection<ObstetricsChildren> ObstetricsChildren { get; set; }
        public virtual ICollection<ObstetricsInvestigations> ObstetricsInvestigations { get; set; }
        public virtual ICollection<ObstetricsObservations> ObstetricsObservations { get; set; }
        public virtual ICollection<ObstetricsPostnatalVisits> ObstetricsPostnatalVisits { get; set; }
        public virtual ICollection<ObstetricsPregnancies> ObstetricsPregnancies { get; set; }
        public virtual ICollection<PastProcedures> PastProcedures { get; set; }
        public virtual ICollection<PatientReportLinks> PatientReportLinks { get; set; }
        public virtual ICollection<Patients> Patients { get; set; }
        public virtual ICollection<PracticesSpecialties> PracticesSpecialties { get; set; }
        public virtual ICollection<Preferences> Preferences { get; set; }
        public virtual ICollection<PrescriptionAuthorities> PrescriptionAuthorities { get; set; }
        public virtual ICollection<PrescriptionMedications> PrescriptionMedications { get; set; }
        public virtual ICollection<Prescriptions> Prescriptions { get; set; }
        public virtual ICollection<PrintTemplates> PrintTemplates { get; set; }
        public virtual ICollection<PrivateMbsFees> PrivateMbsFees { get; set; }
        public virtual ICollection<ProcedureCategories> ProcedureCategories { get; set; }
        public virtual ICollection<ProcedureReferences> ProcedureReferences { get; set; }
        public virtual ICollection<Procedures> Procedures { get; set; }
        public virtual ICollection<ReasonsForEncounter> ReasonsForEncounter { get; set; }
        public virtual ICollection<Recipients> Recipients { get; set; }
        public virtual ICollection<Referrals> Referrals { get; set; }
        public virtual ICollection<ReportLinkSuggestions> ReportLinkSuggestions { get; set; }
        public virtual ICollection<RequestLabProviders> RequestLabProviders { get; set; }
        public virtual ICollection<RequestLabs> RequestLabs { get; set; }
        public virtual ICollection<RolePermissions> RolePermissions { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<ScreeningInteractions> ScreeningInteractions { get; set; }
        public virtual ICollection<ScreeningOverrides> ScreeningOverrides { get; set; }
        public virtual ICollection<Services> Services { get; set; }
        public virtual ICollection<SitesOfService> SitesOfService { get; set; }
        public virtual ICollection<TermsAcceptances> TermsAcceptances { get; set; }
        public virtual ICollection<ThirdPartyClaims> ThirdPartyClaims { get; set; }
        public virtual ICollection<ToDoComments> ToDoComments { get; set; }
        public virtual ICollection<ToDos> ToDos { get; set; }
        public virtual ICollection<Txns> Txns { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<UsersToDos> UsersToDos { get; set; }
        public virtual ICollection<Vouchers> Vouchers { get; set; }
    }
}
