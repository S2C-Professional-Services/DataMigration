using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ToDos
    {
        public ToDos()
        {
            ToDoComments = new HashSet<ToDoComments>();
            UsersToDos = new HashSet<UsersToDos>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? PatientId { get; set; }
        public Guid? PatientReportLinkId { get; set; }
        public Guid? CompleterId { get; set; }
        public string ActionName { get; set; }
        public string Context { get; set; }
        public string Note { get; set; }
        public bool Important { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public DateTime? DueOn { get; set; }
        public string Type { get; set; }
        public DateTime? RemindOn { get; set; }
        public string ReminderSettings { get; set; }
        public Guid? EntityId { get; set; }
        public string EntityType { get; set; }

        public virtual Users Completer { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual PatientReportLinks PatientReportLink { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual ICollection<ToDoComments> ToDoComments { get; set; }
        public virtual ICollection<UsersToDos> UsersToDos { get; set; }
    }
}
