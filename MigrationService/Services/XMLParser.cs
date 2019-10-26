using MigrationService.Models;
using S2CDataMigrationConsole.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace S2CDataMigrationConsole.Services
{
    public class XMLParser
    {
        private XmlDocument XmlDocument { get; set; }
        public XMLParser(string filepath)
        {
            //string exe = Process.GetCurrentProcess().MainModule.FileName;
            //string DirectoryPath = Path.GetDirectoryName(exe) + @"\XMLFiles\";
            //string filepath = DirectoryPath + fileName;
            try
            {
                XmlDocument = new XmlDocument();
                XmlDocument.Load(filepath);
            }
            catch (Exception)
            {
                XmlDocument = null;
                LogService.LogDetails("Error reading file at: " + filepath);
            }
        }
        public List<MigrationContact> GetContacts()
        {
            List<MigrationContact> migrationContacts = new List<MigrationContact>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationContactNodes = XmlDocument.SelectNodes("TransferData/Contacts/MigrationContact");
                foreach (XmlNode migrationContactNode in migrationContactNodes)
                {
                    MigrationContact migrationContact = new MigrationContact();
                    try
                    {
                        migrationContact.ExternalId = Convert.ToInt32(GetInnerText(migrationContactNode.SelectSingleNode("ExternalId")));
                        migrationContact.AddressLine1 = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("AddressLine1")));
                        migrationContact.AddressLine2 = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("AddressLine2")));
                        migrationContact.Alltalk = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("Alltalk")));
                        migrationContact.Argus = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("Argus")));
                        migrationContact.Category = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("Category")));
                        migrationContact.CompanyName = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("CompanyName")));
                        migrationContact.DivisionReport = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("DivisionReport")));
                        migrationContact.Email = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("Email")));
                        migrationContact.FirstName = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("FirstName")));
                        migrationContact.HealthLink = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("HealthLink")));
                        migrationContact.LastName = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("LastName")));
                        migrationContact.MedicalObjects = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("MedicalObjects")));
                        migrationContact.MiddleName = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("MiddleName")));
                        migrationContact.ProviderNo = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("ProviderNo")));
                        migrationContact.ReferralNet = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("ReferralNet")));
                        migrationContact.Fax = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("Fax")));
                        migrationContact.HomePhone = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("HomePhone")));
                        migrationContact.WorkPhone = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("WorkPhone")));
                        migrationContact.MobilePhone = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("MobilePhone")));
                        migrationContact.HPI = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("HPI")));
                        migrationContact.Salutation = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("Salutation")));
                        migrationContact.Country = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("Country")));
                        migrationContact.State = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("State")));
                        migrationContact.Suburb = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("Suburb")));
                        migrationContact.PostCode = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("PostCode")));
                        migrationContact.IsAssistant = Convert.ToBoolean(GetInnerText(migrationContactNode.SelectSingleNode("IsAssistant")));
                        migrationContact.IsSpecialist = Convert.ToBoolean(GetInnerText(migrationContactNode.SelectSingleNode("IsSpecialist")));
                        migrationContact.Specialty = Convert.ToString(GetInnerText(migrationContactNode.SelectSingleNode("Specialty")));

                        migrationContacts.Add(migrationContact);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }

            return migrationContacts;
        }
        public List<MigrationPatient> GetPatients()
        {
            List<MigrationPatient> migrationPatients = new List<MigrationPatient>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationPatientNodes = XmlDocument.SelectNodes("TransferData/Patients/MigrationPatient");
                foreach (XmlNode migrationPatientNode in migrationPatientNodes)
                {
                    MigrationPatient migrationPatient = new MigrationPatient();
                    try
                    {
                        migrationPatient.ExternalId = Convert.ToInt32(GetInnerText(migrationPatientNode.SelectSingleNode("ExternalId")));
                        migrationPatient.FirstName = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("FirstName")));
                        migrationPatient.LastName = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("LastName")));
                        migrationPatient.MiddleName = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("MiddleName")));
                        migrationPatient.MaidenName = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("MaidenName")));
                        migrationPatient.GuardianState = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("GuardianState")));
                        migrationPatient.EmergencyPersonName = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("EmergencyPersonName")));
                        migrationPatient.EmergencyPersonPhone = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("EmergencyPersonPhone")));
                        migrationPatient.Gender = Convert.ToBoolean(GetInnerText(migrationPatientNode.SelectSingleNode("Gender")));
                        if (!string.IsNullOrEmpty(GetInnerText(migrationPatientNode.SelectSingleNode("DateOfBirth"))))
                        {
                            migrationPatient.DateOfBirth = Convert.ToDateTime(GetInnerText(migrationPatientNode.SelectSingleNode("DateOfBirth")));
                        }
                        migrationPatient.ChartNumber = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("ChartNumber")));
                        migrationPatient.AddressLine1 = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("AddressLine1")));
                        migrationPatient.AddressLine2 = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("AddressLine2")));
                        migrationPatient.Country = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("Country")));
                        migrationPatient.State = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("State")));
                        migrationPatient.Suburb = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("Suburb")));
                        migrationPatient.PostCode = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("PostCode")));
                        migrationPatient.CountryOfBirth = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("CountryOfBirth")));
                        migrationPatient.HomePhone = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("HomePhone")));
                        migrationPatient.WorkPhone = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("WorkPhone")));
                        migrationPatient.MobilePhone = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("MobilePhone")));
                        migrationPatient.Email = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("Email")));
                        migrationPatient.Drinking = Convert.ToBoolean(GetInnerText(migrationPatientNode.SelectSingleNode("Drinking")));
                        migrationPatient.MedicareNum = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("MedicareNum")));
                        migrationPatient.MedicareRefNum = Convert.ToInt32(GetInnerText(migrationPatientNode.SelectSingleNode("MedicareRefNum")));
                        if (!string.IsNullOrEmpty(GetInnerText(migrationPatientNode.SelectSingleNode("MedicareExpiryDate"))))
                        {
                            migrationPatient.MedicareExpiryDate = Convert.ToDateTime(GetInnerText(migrationPatientNode.SelectSingleNode("MedicareExpiryDate")));
                        }
                        migrationPatient.AccountType = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("AccountType")));
                        migrationPatient.Language = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("Language")));
                        migrationPatient.DoNotSendSms = Convert.ToBoolean(GetInnerText(migrationPatientNode.SelectSingleNode("DoNotSendSms")));
                        migrationPatient.DvaNumber = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("DvaNumber")));
                        migrationPatient.DvaDisability = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("DvaDisability")));
                        migrationPatient.HealthFundNumber = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("HealthFundNumber")));
                        migrationPatient.HealthFundCode = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("HealthFundCode")));
                        if (!string.IsNullOrEmpty(GetInnerText(migrationPatientNode.SelectSingleNode("DateOfDecease"))))
                        {
                            migrationPatient.DateOfDecease = Convert.ToDateTime(GetInnerText(migrationPatientNode.SelectSingleNode("DateOfDecease")));
                        }
                        migrationPatient.AdvisedDateOfDecease = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("AdvisedDateOfDecease")));
                        migrationPatient.IsDeceased = Convert.ToBoolean(GetInnerText(migrationPatientNode.SelectSingleNode("IsDeceased")));
                        migrationPatient.KnownAs = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("KnownAs")));
                        migrationPatient.NextOfKinName = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("NextOfKinName")));
                        migrationPatient.NextOfKinContactPhone = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("NextOfKinContactPhone")));
                        migrationPatient.Salutation = Convert.ToString(GetInnerText(migrationPatientNode.SelectSingleNode("Salutation")));
                        if (!string.IsNullOrEmpty(GetInnerText(migrationPatientNode.SelectSingleNode("DvaCardExpiry"))))
                        {
                            migrationPatient.DvaCardExpiry = Convert.ToDateTime(GetInnerText(migrationPatientNode.SelectSingleNode("DvaCardExpiry")));
                        }
                        migrationPatient.IsInactive = Convert.ToBoolean(GetInnerText(migrationPatientNode.SelectSingleNode("IsInactive")));

                        migrationPatients.Add(migrationPatient);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationPatients;
        }
        public List<MigrationUser> GetUsers()
        {
            List<MigrationUser> migrationUsers = new List<MigrationUser>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationUserNodes = XmlDocument.SelectNodes("TransferData/Users/MigrationUser");

                foreach (XmlNode migrationUserNode in migrationUserNodes)
                {
                    MigrationUser migrationUser = new MigrationUser();
                    try
                    {
                        migrationUser.ExternalId = Convert.ToInt32(GetInnerText(migrationUserNode.SelectSingleNode("ExternalId")));
                        migrationUser.Salutation = Convert.ToString(GetInnerText(migrationUserNode.SelectSingleNode("Salutation")));
                        migrationUser.FirstName = Convert.ToString(GetInnerText(migrationUserNode.SelectSingleNode("FirstName")));
                        migrationUser.Surname = Convert.ToString(GetInnerText(migrationUserNode.SelectSingleNode("Surname")));
                        migrationUser.IsSpecialist = Convert.ToBoolean(GetInnerText(migrationUserNode.SelectSingleNode("IsSpecialist")));
                        migrationUser.IsReceptionist = Convert.ToBoolean(GetInnerText(migrationUserNode.SelectSingleNode("IsReceptionist")));
                        migrationUsers.Add(migrationUser);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationUsers;
        }
        public List<MigrationAccountHolder> GetAccountHolders()
        {
            List<MigrationAccountHolder> migrationAccountHolders = new List<MigrationAccountHolder>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationAccountHolderNodes = XmlDocument.SelectNodes("TransferData/AccountHolders/MigrationAccountHolder");

                foreach (XmlNode migrationAccountHolderNode in migrationAccountHolderNodes)
                {
                    MigrationAccountHolder migrationAccountHolder = new MigrationAccountHolder();
                    try
                    {
                        migrationAccountHolder.ExternalId = Convert.ToInt32(GetInnerText(migrationAccountHolderNode.SelectSingleNode("ExternalId")));
                        migrationAccountHolder.Individual = Convert.ToBoolean(GetInnerText(migrationAccountHolderNode.SelectSingleNode("Individual")));
                        migrationAccountHolder.FirstName = Convert.ToString(GetInnerText(migrationAccountHolderNode.SelectSingleNode("FirstName")));
                        migrationAccountHolder.LastName = Convert.ToString(GetInnerText(migrationAccountHolderNode.SelectSingleNode("LastName")));
                        migrationAccountHolder.MedicareNum = Convert.ToString(GetInnerText(migrationAccountHolderNode.SelectSingleNode("MedicareNum")));
                        migrationAccountHolder.MedicareRefNum = Convert.ToInt32(GetInnerText(migrationAccountHolderNode.SelectSingleNode("MedicareRefNum")));
                        if (!string.IsNullOrEmpty(GetInnerText(migrationAccountHolderNode.SelectSingleNode("MedicareExpiryDate"))))
                        {
                            migrationAccountHolder.MedicareExpiryDate = Convert.ToDateTime(GetInnerText(migrationAccountHolderNode.SelectSingleNode("MedicareExpiryDate")));
                        }

                        migrationAccountHolder.AddressLine1 = Convert.ToString(GetInnerText(migrationAccountHolderNode.SelectSingleNode("AddressLine1")));
                        migrationAccountHolder.AddressLine2 = Convert.ToString(GetInnerText(migrationAccountHolderNode.SelectSingleNode("AddressLine2")));
                        migrationAccountHolder.Suburb = Convert.ToString(GetInnerText(migrationAccountHolderNode.SelectSingleNode("Suburb")));
                        migrationAccountHolder.State = Convert.ToString(GetInnerText(migrationAccountHolderNode.SelectSingleNode("State")));
                        migrationAccountHolder.PostCode = Convert.ToString(GetInnerText(migrationAccountHolderNode.SelectSingleNode("PostCode")));

                        if (!string.IsNullOrEmpty(GetInnerText(migrationAccountHolderNode.SelectSingleNode("DateOfBirth"))))
                        {
                            migrationAccountHolder.DateOfBirth = Convert.ToDateTime(GetInnerText(migrationAccountHolderNode.SelectSingleNode("DateOfBirth")));
                        }

                        var patientExternalIds = new List<string>();

                        foreach (XmlNode patientExternalIdNode in migrationAccountHolderNode.SelectSingleNode("PatientExternalIds").SelectNodes("string"))
                        {
                            patientExternalIds.Add(GetInnerText(patientExternalIdNode));
                        }

                        migrationAccountHolder.PatientExternalIds = patientExternalIds.ToArray(); //Convert.ToBoolean(GetInnerText(migrationAccountHolderNode.SelectSingleNode("IsReceptionist")));
                        migrationAccountHolders.Add(migrationAccountHolder);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationAccountHolders;
        }

        public List<MigrationReferral> GetReferrals()
        {
            List<MigrationReferral> migrationEntities = new List<MigrationReferral>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Referrals/MigrationReferral");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationReferral migrationEntity = new MigrationReferral();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));
                        
                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationAppointmentType> GetAppointmentTypes()
        {
            List<MigrationAppointmentType> migrationEntities = new List<MigrationAppointmentType>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/AppointmentTypes/MigrationAppointmentType");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationAppointmentType migrationEntity = new MigrationAppointmentType();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationAppointment> GetAppointments()
        {
            List<MigrationAppointment> migrationEntities = new List<MigrationAppointment>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Appointments/MigrationAppointment");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationAppointment migrationEntity = new MigrationAppointment();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationConsult> GetConsults()
        {
            List<MigrationConsult> migrationEntities = new List<MigrationConsult>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Consults/MigrationConsult");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationConsult migrationEntity = new MigrationConsult();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationAllergy> GetAllergies()
        {
            List<MigrationAllergy> migrationEntities = new List<MigrationAllergy>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Allergies/MigrationAllergy");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationAllergy migrationEntity = new MigrationAllergy();
                    try
                    {
                       // migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationMeasurement> GetMeasurements()
        {
            List<MigrationMeasurement> migrationEntities = new List<MigrationMeasurement>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Measurements/MigrationMeasurement");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationMeasurement migrationEntity = new MigrationMeasurement();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationTask> GetTasks()
        {
            List<MigrationTask> migrationEntities = new List<MigrationTask>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Tasks/MigrationTask");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationTask migrationEntity = new MigrationTask();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationLetter> GetLetters()
        {
            List<MigrationLetter> migrationEntities = new List<MigrationLetter>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Letters/MigrationLetter");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationLetter migrationEntity = new MigrationLetter();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationLaboratoryResult> GetLaboratoryResults()
        {
            List<MigrationLaboratoryResult> migrationEntities = new List<MigrationLaboratoryResult>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/LaboratoryResults/MigrationLaboratoryResult");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationLaboratoryResult migrationEntity = new MigrationLaboratoryResult();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationDocument> GetDocuments()
        {
            List<MigrationDocument> migrationEntities = new List<MigrationDocument>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Documents/MigrationDocument");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationDocument migrationEntity = new MigrationDocument();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationCompany> GetCompanies()
        {
            List<MigrationCompany> migrationEntities = new List<MigrationCompany>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Companies/MigrationCompany");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationCompany migrationEntity = new MigrationCompany();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationRecall> GetRecalls()
        {
            List<MigrationRecall> migrationEntities = new List<MigrationRecall>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/Recalls/MigrationRecall");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationRecall migrationEntity = new MigrationRecall();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationOnGHistoryRecord> GetOnGHistoryRecords()
        {
            List<MigrationOnGHistoryRecord> migrationEntities = new List<MigrationOnGHistoryRecord>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/OnGHistoryRecords/MigrationOnGHistoryRecord");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationOnGHistoryRecord migrationEntity = new MigrationOnGHistoryRecord();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationOnGRecord> GetOnGRecords()
        {
            List<MigrationOnGRecord> migrationEntities = new List<MigrationOnGRecord>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/OnGRecords/MigrationOnGRecord");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationOnGRecord migrationEntity = new MigrationOnGRecord();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationOnGAntenatal> GetOnGAntenatalVisits()
        {
            List<MigrationOnGAntenatal> migrationEntities = new List<MigrationOnGAntenatal>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/OnGAntenatalVisits/MigrationOnGAntenatal");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationOnGAntenatal migrationEntity = new MigrationOnGAntenatal();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }
        public List<MigrationInterestedParty> GetInterestedParties()
        {
            List<MigrationInterestedParty> migrationEntities = new List<MigrationInterestedParty>();
            if (XmlDocument != null)
            {
                XmlNodeList migrationEntityNodes = XmlDocument.SelectNodes("TransferData/InterestedParties/MigrationInterestedParty");

                foreach (XmlNode migrationEntityNode in migrationEntityNodes)
                {
                    MigrationInterestedParty migrationEntity = new MigrationInterestedParty();
                    try
                    {
                        migrationEntity.ExternalId = Convert.ToInt32(GetInnerText(migrationEntityNode.SelectSingleNode("ExternalId")));
                        //migrationEntity.Salutation = Convert.ToString(GetInnerText(migrationEntityNode.SelectSingleNode("Salutation")));

                        migrationEntities.Add(migrationEntity);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error in reading XML: " + e.Message, "xmlError");
                    }
                }
            }
            return migrationEntities;
        }

        private string GetInnerText(XmlNode migrationPatientNode)
        {
            if (migrationPatientNode != null)
                return migrationPatientNode.InnerText;
            else
                return null;
        }
    }
}
