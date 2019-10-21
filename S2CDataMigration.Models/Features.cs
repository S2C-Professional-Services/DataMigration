using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Features
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
