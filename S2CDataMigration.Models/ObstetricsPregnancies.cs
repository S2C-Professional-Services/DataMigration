using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ObstetricsPregnancies
    {
        public ObstetricsPregnancies()
        {
            ObstetricsAntenatalVisits = new HashSet<ObstetricsAntenatalVisits>();
            ObstetricsChildren = new HashSet<ObstetricsChildren>();
            ObstetricsInvestigations = new HashSet<ObstetricsInvestigations>();
            ObstetricsObservations = new HashSet<ObstetricsObservations>();
            ObstetricsPostnatalVisits = new HashSet<ObstetricsPostnatalVisits>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public DateTime? DeliveredOn { get; set; }
        public DateTime? LmpOn { get; set; }
        public DateTime? AgreedEddOn { get; set; }
        public string AgreedEddBasis { get; set; }
        public string ConceptionType { get; set; }
        public string LengthOfLabour { get; set; }
        public string Induction { get; set; }
        public string DeliveryMethod { get; set; }
        public string Analgesia { get; set; }
        public string PregnancyProblems { get; set; }
        public string LabourProblems { get; set; }
        public string PlaceOfBirth { get; set; }
        public Guid? HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Partner { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Current { get; set; }
        public string TimeOfBirth { get; set; }
        public string PostBirth { get; set; }
        public string Accoucher { get; set; }
        public string Paediatrician { get; set; }
        public string Anaesthetist { get; set; }
        public string Comments { get; set; }
        public Guid? ProviderId { get; set; }
        public bool AsHistory { get; set; }
        public string BloodGroup { get; set; }
        public Guid? LocalId { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public string AdditionalComments { get; set; }
        public bool? BreastFed { get; set; }

        public virtual Contacts Hospital { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Users Provider { get; set; }
        public virtual ICollection<ObstetricsAntenatalVisits> ObstetricsAntenatalVisits { get; set; }
        public virtual ICollection<ObstetricsChildren> ObstetricsChildren { get; set; }
        public virtual ICollection<ObstetricsInvestigations> ObstetricsInvestigations { get; set; }
        public virtual ICollection<ObstetricsObservations> ObstetricsObservations { get; set; }
        public virtual ICollection<ObstetricsPostnatalVisits> ObstetricsPostnatalVisits { get; set; }
    }
}
