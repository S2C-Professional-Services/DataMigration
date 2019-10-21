using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Permissions
    {
        public Permissions()
        {
            RolePermissions = new HashSet<RolePermissions>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<RolePermissions> RolePermissions { get; set; }
    }
}
