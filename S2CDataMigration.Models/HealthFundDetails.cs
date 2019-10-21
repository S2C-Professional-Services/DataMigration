using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class HealthFundDetails
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid UserId { get; set; }
        public Guid HealthFundId { get; set; }
        public Guid? HealthFundScheduleId { get; set; }
        public string PayeeId { get; set; }
        public string ClaimType { get; set; }
        public string BillingType { get; set; }
        public decimal? KnownGap { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual HealthFunds HealthFund { get; set; }
        public virtual FeeSchedules HealthFundSchedule { get; set; }
        public virtual Practices Practice { get; set; }
        public virtual Users User { get; set; }
    }
}
