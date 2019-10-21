using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class AdminNoteVersions
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PatientId { get; set; }
        public long? TransactionId { get; set; }
        public Guid ItemId { get; set; }
        public string ItemType { get; set; }
        public string Event { get; set; }
        public string Whodunnit { get; set; }
        public string Object { get; set; }
        public string ObjectChanges { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
