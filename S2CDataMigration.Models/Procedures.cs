using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Procedures
    {
        public Procedures()
        {
            BillingItemsProcedures = new HashSet<BillingItemsProcedures>();
            ProcedureReferences = new HashSet<ProcedureReferences>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public Guid UserId { get; set; }
        public Guid? BusinessContactId { get; set; }
        public Guid? AssistantContactId { get; set; }
        public Guid? AnaesthetistContactId { get; set; }
        public Guid? PaediatricianContactId { get; set; }
        public DateTime? StartsAt { get; set; }
        public DateTime? AdmittedOn { get; set; }
        public DateTime? FollowedUpOn { get; set; }
        public int? Duration { get; set; }
        public int? InpatientNights { get; set; }
        public int? Asa { get; set; }
        public string ProcedureType { get; set; }
        public bool? Left { get; set; }
        public bool? Right { get; set; }
        public bool? ConsentSigned { get; set; }
        public string PreOpNotes { get; set; }
        public string PostOpNotes { get; set; }
        public string Findings { get; set; }
        public string Technique { get; set; }
        public string SpecificOutcomes { get; set; }
        public string Name { get; set; }
        public string InfectionRisk { get; set; }
        public string Urgency { get; set; }
        public string Anaesthetic { get; set; }
        public string Prosthetic { get; set; }
        public string BloodLoss { get; set; }
        public int Outcomes { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public Guid? ThirdPartyClaimId { get; set; }
        public bool Billed { get; set; }
        public Guid? ProcedureCategoryId { get; set; }
        public bool InvoiceNotRequired { get; set; }
        public Guid? RestrictedById { get; set; }
        public DateTime? RestrictedAt { get; set; }

        public virtual Contacts AnaesthetistContact { get; set; }
        public virtual Contacts AssistantContact { get; set; }
        public virtual Contacts BusinessContact { get; set; }
        public virtual Contacts PaediatricianContact { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ProcedureCategories ProcedureCategory { get; set; }
        public virtual Users RestrictedBy { get; set; }
        public virtual ThirdPartyClaims ThirdPartyClaim { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<BillingItemsProcedures> BillingItemsProcedures { get; set; }
        public virtual ICollection<ProcedureReferences> ProcedureReferences { get; set; }
    }
}
