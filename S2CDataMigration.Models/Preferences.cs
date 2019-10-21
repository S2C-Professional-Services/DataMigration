using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class Preferences
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string DayStartTime { get; set; }
        public string DayEndTime { get; set; }
        public int AppointmentDuration { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string AppointmentReminderSchedule { get; set; }

        public virtual Practices Practice { get; set; }
    }
}
