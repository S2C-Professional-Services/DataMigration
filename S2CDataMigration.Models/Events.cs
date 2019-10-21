using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Events
    {
        public Events()
        {
            InverseRecurrence = new HashSet<Events>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid? PatientId { get; set; }
        public Guid? AppointmentTypeId { get; set; }
        public DateTime StartsAt { get; set; }
        public int Duration { get; set; }
        public string Note { get; set; }
        public DateTime? CancelledAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid ProviderId { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public bool IsScheduled { get; set; }
        public string RecurringRule { get; set; }
        public string SmsStatus { get; set; }
        public Guid? SiteOfServiceId { get; set; }
        public bool Billed { get; set; }
        public bool InvoiceNotRequired { get; set; }
        public Guid? RecurrenceId { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? UpdaterId { get; set; }
        public bool? UpdatingOccurrences { get; set; }

        public virtual AppointmentTypes AppointmentType { get; set; }
        public virtual Patients Patient { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Users Provider { get; set; }
        public virtual Events Recurrence { get; set; }
        public virtual ICollection<Events> InverseRecurrence { get; set; }
    }
}
