using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationService.Models
{
    public class MigrationOnGRecord
    {
        public int ExternalId { get; set; }
        public int PatientExternalId { get; set; }
        public DateTime Lmp { get; set; }
        public DateTime Edd { get; set; }
        public int Hb { get; set; }
        public int Mcv { get; set; }
        public int Uss1Weeks { get; set; }
        public int Uss2Weeks { get; set; }
        public int Uss3Weeks { get; set; }
        public int Hb28Wks { get; set; }
        public int Hb36Wks { get; set; }
        public bool Declined { get; set; }
        public bool AntiD28 { get; set; }

        public bool AntiD36 { get; set; }
        public int VitaminD { get; set; }
        public int Ebl { get; set; }
        public float Gtt28Fasting { get; set; }
        public int Bp { get; set; }
        public string PlacentalPosition { get; set; }
        //public DateTime DeliveryDateTime { get; set; }
        //public DateTime PostnatalDate { get; set; }
        public DateTime Uss1Date { get; set; }
        public DateTime Uss2Date { get; set; }
        public DateTime Uss3Date { get; set; }
        public DateTime EddAgreed { get; set; }
        public DateTime InitialTestDate { get; set; }
        public int Hospital { get; set; }
        public float Gtt282Hr { get; set; }
        public int TwentyWeekFee { get; set; }
        public int ThirtyWeekFee { get; set; }
        public int Platelets28 { get; set; }
        public bool Breastfeeding { get; set; }
        public bool BreastfeedingAtDelivery { get; set; }
        public int Lochia { get; set; }
        public int PerineumState { get; set; }
        public int Bladder { get; set; }
        public int Bowel { get; set; }
        public int BreastState { get; set; }
        public int PnBreasts { get; set; }
        public int PnAbdo { get; set; }
        public int PnPerineum { get; set; }
        public string CurrentIssues { get; set; }
        public int UserExternalId { get; set; }

    }
}
