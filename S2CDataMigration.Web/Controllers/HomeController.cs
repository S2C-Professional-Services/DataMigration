using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S2CDataMigration.Web.Models;

namespace S2CDataMigration.Web.Controllers
{
    public class HomeController : Controller
    {
        private string ABNNumber { get; set; }
        private bool IsAdmin { get; set; }
        private string ClientName { get; set; }
        private string MigrationType { get; set; }
        private string PhoneNumber { get; set; }
        public string ConnectionString { get; set; }
        public HomeController()
        {
            //BSBNumber = HttpContext.Session.GetString("BSBNumber");
        }
        public IActionResult Index()
        {
            SetProperties();
            if (!string.IsNullOrEmpty(ABNNumber))
            {
                HomeViewModel homeViewModel = GenerateViewModel();

                return View(homeViewModel);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        private HomeViewModel GenerateViewModel()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.ABNNumber = ABNNumber;
            homeViewModel.ClientName = ClientName;
            homeViewModel.MigrationType = MigrationType;
            homeViewModel.PhoneNumber = PhoneNumber;
            homeViewModel.ConnectionString = ConnectionString;
            homeViewModel.IsAdmin = IsAdmin;
            return homeViewModel;
        }

        private void SetProperties()
        {
            ABNNumber = HttpContext.Session.GetString("ABNNumber");
            ClientName = HttpContext.Session.GetString("ClientName");
            MigrationType = HttpContext.Session.GetString("MigrationType");
            PhoneNumber = HttpContext.Session.GetString("PhoneNumber");
            ConnectionString = HttpContext.Session.GetString("ConnectionString");
            IsAdmin = Convert.ToBoolean(HttpContext.Session.GetString("IsAdmin"));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            SetProperties();
            if (!string.IsNullOrEmpty(ABNNumber))
            {
                HomeViewModel homeViewModel = GenerateViewModel();
                return View("Contact",homeViewModel);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
