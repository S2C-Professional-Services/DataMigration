using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class CustomMedications
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string Name { get; set; }
        public string FormStrength { get; set; }
        public string Quantity { get; set; }
        public int? Repeats { get; set; }
        public string Scheme { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Gddid { get; set; }
        public string GddType { get; set; }
        public string GenericDrugCode { get; set; }

        public virtual Practices Practice { get; set; }
    }
}
