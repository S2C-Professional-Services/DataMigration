using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2CDataMigrationConsole.Models
{
    public class MigrationPatient
    {
        public int ExternalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public string GuardianState { get; set; }
        public string EmergencyPersonName { get; set; }
        public string EmergencyPersonPhone { get; set; }
        public bool Gender { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string ChartNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string CountryOfBirth { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public bool Drinking { get; set; }
        public string MedicareNum { get; set; }
        public int MedicareRefNum { get; set; }
        public Nullable<DateTime> MedicareExpiryDate { get; set; } 
        public string AccountType { get; set; }                    
        public string Language { get; set; }                       
        public bool DoNotSendSms { get; set; }                     
        public string DvaNumber { get; set; }                      
        public string DvaDisability { get; set; }
        public string HealthFundNumber { get; set; }
        public string HealthFundCode { get; set; }
        public Nullable<DateTime> DateOfDecease { get; set; }
        public string AdvisedDateOfDecease { get; set; }
        public bool IsDeceased { get; set; }
        public string KnownAs { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinContactPhone { get; set; }
        public string Salutation { get; set; }
        public Nullable<DateTime> DvaCardExpiry { get; set; }
        public bool IsInactive { get; set; }



    }
}


/*
        migrationPatient.ExternalId 
        migrationPatient.FirstName 
        migrationPatient.LastName 
        migrationPatient.MiddleName 
        migrationPatient.MaidenName 
        migrationPatient.GuardianState 
        EmergencyPersonName 
        EmergencyPersonPhone 
        Gender 
        DateOfBirth 
        ChartNumber 
        AddressLine1 
        AddressLine2 
        Country 
        State 
        Suburb 
        PostCode 
        CountryOfBirth 
        HomePhone 
        WorkPhone 
        MobilePhone 
        Email 
        Drinking 
        MedicareNum 
        MedicareRefNum 
        MedicareExpiryDate  
        AccountType                     
        Language                        
        DoNotSendSms                      
        DvaNumber                       
        DvaDisability 
        HealthFundNumber 
        HealthFundCode 
        DateOfDecease 
        AdvisedDateOfDecease 
        IsDeceased 
        KnownAs 
        NextOfKinName 
        NextOfKinContactPhone 
        Salutation 
        DvaCardExpiry 
        IsInactive  
     
     */
