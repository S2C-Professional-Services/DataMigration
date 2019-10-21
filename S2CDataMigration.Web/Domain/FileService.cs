using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using S2CDataMigration.Web.Constants;
using S2CDataMigration.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace S2CDataMigration.Web.Domain
{
    public class FileService
    {
        public FileService()
        {

        }
        public List<ClientSetting> GetClientSettings()
        {
            var path = System.IO.Directory.GetCurrentDirectory();
            var clientSetting = GetJson(path, "client-settings");
            List<ClientSetting> clients = new List<ClientSetting>();
            foreach (var item in JsonConvert.DeserializeObject<List<ClientSetting>>(clientSetting))
            {
                clients.Add(item);
                //    new ClientSetting()
                //{
                //    ABNNumber = Convert.ToString(item["abnNumber"]),
                //    ClientName = Convert.ToString(item["clientName"]),
                //    IsAdmin = Convert.ToBoolean(item["isAdmin"])
                //});
            }
            return clients;
        }
        public List<ClientFile> GetPreviousFiles(string abnNumber)
        {
            List<ClientFile> files = new List<ClientFile>();
            var path = System.IO.Directory.GetCurrentDirectory();
            var fileList = GetJson(path, "client-files");
            foreach (var item in JsonConvert.DeserializeObject<List<ClientFile>>(fileList))
            {
                files.Add(item);
                //    new ClientFile()
                //{
                //    ABNNumber = Convert.ToString(item["abnNumber"]),
                //    FileName = Convert.ToString(item["fileName"]),
                //    ClientName = Convert.ToString(item["clientName"]),
                //    FilePath = Convert.ToString(item["filePath"]),
                //    UploadedOn = Convert.ToDateTime(item["uploadedOn"])
                //});
            }
            return files.Where(x=>x.ABNNumber.ToLower() == abnNumber.ToLower()).ToList();
        }
        public void AppendNewFileData(ClientFile clientFile)
        {
            List<ClientFile> files = new List<ClientFile>();
            var path = System.IO.Directory.GetCurrentDirectory();
            var fileList = GetJson(path, "client-files");
            foreach (var item in JsonConvert.DeserializeObject<List<ClientFile>>(fileList))
            {
                files.Add(item);
                //    new ClientFile()
                //{
                //    ABNNumber = Convert.ToString(item["abnNumber"]),
                //    FileName = Convert.ToString(item["fileName"]),
                //    ClientName = Convert.ToString(item["clientName"]),
                //    FilePath = Convert.ToString(item["filePath"]),
                //    UploadedOn = Convert.ToDateTime(item["uploadedOn"])
                //});
            }
            files.Add(clientFile);

            // Update json data string
            var jsonData = JsonConvert.SerializeObject(files);
            System.IO.File.WriteAllText(string.Format(@"{0}\{1}.json", path, "client-files"), jsonData);
        }
        public async Task<bool> UploadFile(IFormFile ufile,string clientName, string abnNumber)
        {
            if (ufile != null && ufile.Length > 0)
            {
                var fileName = Path.GetFileNameWithoutExtension(ufile.FileName) + "_" + DateTime.Now.ToString("MMddyyyyHHmmss")+ Path.GetExtension(ufile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\datafiles", fileName );
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ufile.CopyToAsync(fileStream);
                }
                AppendNewFileData(new ClientFile() { FilePath = filePath,
                    FileName = fileName,
                    UploadedOn =DateTime.Now,
                    ClientName = clientName,
                    ABNNumber = abnNumber
                });
                return true;
            }
            return false;
        }
        public string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},  
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"},
                {".xml",MimeTypes.Application.Xml }
            };
        }

        private static string GetJson(string path, string fileName)
        {
            return System.IO.File.ReadAllText(string.Format(@"{0}\{1}.json", path, fileName));
        }

    }
}
