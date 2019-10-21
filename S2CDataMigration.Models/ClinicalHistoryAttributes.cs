using System;
using System.Collections.Generic;
using NpgsqlTypes;

namespace S2CDataMigration.Models
{
    public partial class ClinicalHistoryAttributes
    {
        public ClinicalHistoryAttributes()
        {
            AdverseReactionsAgentAttribute = new HashSet<AdverseReactions>();
            AdverseReactionsManifestationAttribute = new HashSet<AdverseReactions>();
            Diagnoses = new HashSet<Diagnoses>();
            PastProcedures = new HashSet<PastProcedures>();
            ProcedureReferences = new HashSet<ProcedureReferences>();
        }

        public Guid Id { get; set; }
        public string AttrType { get; set; }
        public string Name { get; set; }
        public string SnomedCode { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public NpgsqlTsVector Tsv { get; set; }

        public virtual ICollection<AdverseReactions> AdverseReactionsAgentAttribute { get; set; }
        public virtual ICollection<AdverseReactions> AdverseReactionsManifestationAttribute { get; set; }
        public virtual ICollection<Diagnoses> Diagnoses { get; set; }
        public virtual ICollection<PastProcedures> PastProcedures { get; set; }
        public virtual ICollection<ProcedureReferences> ProcedureReferences { get; set; }
    }
}
