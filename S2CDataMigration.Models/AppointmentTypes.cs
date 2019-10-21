using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class AppointmentTypes
    {
        public AppointmentTypes()
        {
            Events = new HashSet<Events>();
        }

        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public int? Duration { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ICollection<Events> Events { get; set; }
    }
}
