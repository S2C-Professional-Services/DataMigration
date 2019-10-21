using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S2CDataMigration.Web.Domain;
using S2CDataMigration.Web.Models;

namespace S2CDataMigration.Web.Controllers
{
    public class UploadController : Controller
    {
        private string ABNNumber { get; set; }
        private string ClientName { get; set; }
        public IActionResult Index(UploadViewModel uploadViewModel)
        {
            ABNNumber = HttpContext.Session.GetString("ABNNumber");
            ClientName = HttpContext.Session.GetString("ClientName");
            if (!string.IsNullOrEmpty(ABNNumber))
            {
                //UploadViewModel uploadViewModel = new UploadViewModel();
                FileService fileService = new FileService();
                uploadViewModel.Files = fileService.GetPreviousFiles(ABNNumber);
                
                return View(uploadViewModel);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        //[HttpGet]
        //public async Task<ActionResult> Files()
        //{

        //}

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var uploadViewModel = new UploadViewModel();
            if (file == null || file.Length == 0)
            {
                uploadViewModel.Message = "file not selected";
                return RedirectToAction("Index", new { uploadViewModel = uploadViewModel });
            }
            #region Commented
            //var path = Path.Combine(
            //            Directory.GetCurrentDirectory(), "wwwroot\datafiles",
            //            file.GetFilename());

            //using (var stream = new FileStream(path, FileMode.Create))
            //{
            //    await file.CopyToAsync(stream);
            //} 
            #endregion
            ABNNumber = HttpContext.Session.GetString("ABNNumber");
            ClientName = HttpContext.Session.GetString("ClientName");
            FileService fileService = new FileService();
            bool isUploaded = await fileService.UploadFile(file, ClientName, ABNNumber);
            if (isUploaded)
            {
                uploadViewModel.Message= "File is uploaded successfully";
            }
            else
            {
                uploadViewModel.Message = "Something went wrong";
            }
            
            return RedirectToAction("Index",new { uploadViewModel = uploadViewModel });
        }
        public async Task<IActionResult> Download(string filename)
        {
            FileService fileService = new FileService();
            var uploadViewModel = new UploadViewModel();
            if (filename == null)
            {
                uploadViewModel.Message = "filename not present";
                return View("Index", new { uploadViewModel = uploadViewModel });
            }

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot/datafiles", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, fileService.GetContentType(path), Path.GetFileName(path));
        }
    }
}