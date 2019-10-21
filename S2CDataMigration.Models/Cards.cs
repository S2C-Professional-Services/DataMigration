using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Cards
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public string Ref { get; set; }
        public string Expiry { get; set; }
        public string Card { get; set; }
        public string Condition { get; set; }
        public Guid? HealthFundId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string HolderType { get; set; }
        public Guid HolderId { get; set; }

        public virtual Practices Practice { get; set; }
    }
}
