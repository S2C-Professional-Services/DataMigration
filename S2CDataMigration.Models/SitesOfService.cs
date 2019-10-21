using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class SitesOfService
    {
        public SitesOfService()
        {
            Invoices = new HashSet<Invoices>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string ProviderNumber { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Lspn { get; set; }
        public string EquipmentNumber { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
