using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Accounts
    {
        public Accounts()
        {
            AccountsPatients = new HashSet<AccountsPatients>();
            InverseAccount = new HashSet<Accounts>();
            InvoicesAccount = new HashSet<Invoices>();
            InvoicesGapAssignee = new HashSet<Invoices>();
            PracticesDvaAccount = new HashSet<Practices>();
            PracticesMedicareAccount = new HashSet<Practices>();
            Txns = new HashSet<Txns>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? AccountId { get; set; }
        public string HolderType { get; set; }
        public Guid HolderId { get; set; }
        public string Type { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ICollection<AccountsPatients> AccountsPatients { get; set; }
        public virtual ICollection<Accounts> InverseAccount { get; set; }
        public virtual ICollection<Invoices> InvoicesAccount { get; set; }
        public virtual ICollection<Invoices> InvoicesGapAssignee { get; set; }
        public virtual ICollection<Practices> PracticesDvaAccount { get; set; }
        public virtual ICollection<Practices> PracticesMedicareAccount { get; set; }
        public virtual ICollection<Txns> Txns { get; set; }
    }
}
