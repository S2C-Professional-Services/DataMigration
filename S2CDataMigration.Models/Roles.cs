using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Roles
    {
        public Roles()
        {
            RolePermissions = new HashSet<RolePermissions>();
            Users = new HashSet<Users>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid PracticeId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ICollection<RolePermissions> RolePermissions { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
