using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S2CDataMigration.Web.Domain;
using S2CDataMigration.Web.Models;

namespace S2CDataMigration.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            if (loginViewModel != null && !string.IsNullOrEmpty(loginViewModel.ABNNumber))
            {
                FileService fileService = new FileService();
                var clients = fileService.GetClientSettings();
                if(clients != null && clients.Count > 0)
                {
                    var client = clients.Where(x => x.ABNNumber.ToLower() == loginViewModel.ABNNumber.ToLower()).FirstOrDefault();
                    if(client != null)
                    {
                        HttpContext.Session.SetString("ABNNumber", client.ABNNumber);
                        HttpContext.Session.SetString("ClientName", client.ClientName);
                        HttpContext.Session.SetString("ConnectionString", client.ConnectionString);
                        HttpContext.Session.SetString("IsAdmin", client.IsAdmin.ToString());
                        return RedirectToAction("Index", "Home");//new { ABNNumber = client.ABNNumber }
                    }
                }
                ViewData["Message"] = "Invalid ABN number";
                return View();
            }
            else
            {
                ViewData["Message"] = "Please enter ABN number";
                return View();
            }            
        }
    }
}