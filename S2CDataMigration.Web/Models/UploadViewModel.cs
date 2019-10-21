using S2CDataMigration.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2CDataMigration.Web.Models
{
    public class UploadViewModel
    {
        public List<ClientFile> Files { get; set; }
        public string Message { get; set; }
    }
}
