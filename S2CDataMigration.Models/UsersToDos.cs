using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class UsersToDos
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid UserId { get; set; }
        public Guid ToDoId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ToDos ToDo { get; set; }
        public virtual Users User { get; set; }
    }
}
