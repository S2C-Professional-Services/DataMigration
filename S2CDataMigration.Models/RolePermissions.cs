using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class RolePermissions
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
        public bool Enabled { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Permissions Permission { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Roles Role { get; set; }
    }
}
