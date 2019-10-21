using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Medications
    {
        public Medications()
        {
            ScreeningOverrides = new HashSet<ScreeningOverrides>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public string Name { get; set; }
        public string Dose { get; set; }
        public string Quantity { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? FinishedOn { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public bool BrandSubstitutionNotAllowed { get; set; }
        public string TppId { get; set; }
        public string MppId { get; set; }
        public string GenericDrugCode { get; set; }
        public string PbsItemCode { get; set; }
        public string Route { get; set; }
        public int? Repeats { get; set; }
        public string Frequency { get; set; }
        public string Instructions { get; set; }
        public string Reason { get; set; }
        public string RestrictionType { get; set; }
        public string FormStrength { get; set; }
        public string Scheme { get; set; }
        public string State { get; set; }
        public string RestrictionCode { get; set; }
        public int? AuthorityFormNumber { get; set; }
        public string AuthorityCode { get; set; }
        public DateTime? EmergencyCallAt { get; set; }
        public string ClinicalReason { get; set; }
        public Guid? CustomMedicationId { get; set; }
        public int? Gddid { get; set; }
        public string GddType { get; set; }
        public string OtherScheme { get; set; }
        public string OtherRestrictionType { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ICollection<ScreeningOverrides> ScreeningOverrides { get; set; }
    }
}
