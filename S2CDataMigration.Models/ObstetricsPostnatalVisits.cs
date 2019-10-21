using System;
using System.Collections.Generic;

namespace S2CDataMigration.Models
{
    public partial class ObstetricsPostnatalVisits
    {
        public Guid Id { get; set; }
        public Guid PracticeId { get; set; }
        public Guid PregnancyId { get; set; }
        public DateTime? VisitedOn { get; set; }
        public bool? BreastFeeding { get; set; }
        public string Contraception { get; set; }
        public string BloodPressure { get; set; }
        public string HistoryLochia { get; set; }
        public string HistoryPerineum { get; set; }
        public string HistoryBladder { get; set; }
        public string HistoryBowels { get; set; }
        public string HistoryBreasts { get; set; }
        public string ExamBreasts { get; set; }
        public string ExamAbdomen { get; set; }
        public string ExamPerineum { get; set; }
        public string ExamSpeculum { get; set; }
        public string ExamPv { get; set; }
        public string NeonatalExamination { get; set; }
        public string Comments { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Practices Practice { get; set; }
        public virtual ObstetricsPregnancies Pregnancy { get; set; }
    }
}
