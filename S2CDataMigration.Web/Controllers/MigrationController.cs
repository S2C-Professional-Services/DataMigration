using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S2CDataMigration.Models;
using S2CDataMigration.Web.Domain;
using S2CDataMigration.Web.Models;
using S2CDataMigrationConsole.Services;

namespace S2CDataMigration.Web.Controllers
{
    public class MigrationController : Controller
    {
        private string ABNNumber { get; set; }
        private string ClientName { get; set; }
        private IPatientService PatientService { get; set; }
        private IPracticeService PracticeService { get; set; }
        public MigrationController(IPatientService patientService, IPracticeService practiceService)
        {
            PatientService = patientService;
            PracticeService = practiceService;
        }
        public IActionResult Index(string fileName)
        {
            ABNNumber = HttpContext.Session.GetString("ABNNumber");
            ClientName = HttpContext.Session.GetString("ClientName");
            if (!string.IsNullOrEmpty(ABNNumber))
            {
                MigrationViewModel migrationViewModel = ReadData(fileName);
                migrationViewModel.FileName = fileName;
                return View(migrationViewModel);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }


        private MigrationViewModel ReadData(string fileName)
        {
            MigrationViewModel migrationViewModel = new MigrationViewModel();
            migrationViewModel.FileName = fileName;
            if (!string.IsNullOrEmpty(fileName))
            {
                var path = Path.Combine(
                              Directory.GetCurrentDirectory(),
                              "wwwroot/datafiles", migrationViewModel.FileName);
                //Read data here
                XMLParser xmlParser = new XMLParser(path);
                migrationViewModel.MigrationUsers = xmlParser.GetUsers();
                migrationViewModel.MigrationPatients = xmlParser.GetPatients();
                migrationViewModel.MigrationContacts = xmlParser.GetContacts();
                migrationViewModel.MigrationAccountHolders = xmlParser.GetAccountHolders();
            }
            return migrationViewModel;
            //return View("Index", migrationViewModel);
        }
        public ActionResult MigrateData(string fileName)
        {
            MigrationViewModel migrationViewModel = ReadData(fileName);
            //PostgreSQL operations
            var practices = PracticeService.Get();
            Guid practiceId;
            if(practices != null && practices.Count()>0)
            {
                practiceId = practices.First().Id;
            }
            else
            {
                var practice = new Practices()
                {
                    Name = "DemoPractice",
                    Email="demo@practices.com.au",
                    Abn="S2C2343242",
                    Id = Guid.NewGuid(),
                    Timezone = "AEST",
                    PracticeType = "Full",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    LocationCode = "AUS",
                    StateId = new Guid("641d6b03-7417-4278-947f-5eb7f732e40e")

                };
                var addedPractice = PracticeService.Add(practice);
                practiceId = addedPractice.Id;
            }
            var inputModel = migrationViewModel.MigrationPatients.First();
            var contacts = new List<EmergencyContacts>();
            contacts.Add(new EmergencyContacts()
            {
                FirstName = "Bhavik",
                LastName = "Patel",
                PhoneNumber = "12123123123",
                Relationship = "Friend",
                PracticeId = practiceId
            });
            var patientModel = new Patients()
            {
                FirstName = inputModel.FirstName,
                MiddleName = inputModel.MiddleName,
                LastName = inputModel.LastName,
               MaidenName = inputModel.MaidenName,
               Email = inputModel.Email,
               EmergencyContacts = contacts,
               PracticeId= practiceId
            };
            var addedPatient = PatientService.Add(patientModel);
            migrationViewModel.Message = "Data migrated successfully";
            return View("Index", migrationViewModel);
        }
    }
}