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
        public HomeController()
        {
            //BSBNumber = HttpContext.Session.GetString("BSBNumber");
        }
        public IActionResult Index()
        {
            ABNNumber = HttpContext.Session.GetString("ABNNumber");
            ClientName = HttpContext.Session.GetString("ClientName");
            IsAdmin = Convert.ToBoolean(HttpContext.Session.GetString("IsAdmin"));
            if (!string.IsNullOrEmpty(ABNNumber))
            {
                HomeViewModel homeViewModel = new HomeViewModel();
                homeViewModel.ABNNumber = ABNNumber;
                homeViewModel.ClientName = ClientName;
                homeViewModel.IsAdmin = IsAdmin;

                return View(homeViewModel);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
