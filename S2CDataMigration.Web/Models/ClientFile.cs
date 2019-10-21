using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2CDataMigration.Web.Models
{
    public class ClientFile
    {
        public string FileName { get; set; }
        public string ABNNumber { get; set; }
        public string ClientName { get; set; }
        public DateTime UploadedOn { get; set; }
        public string FilePath { get; set; }
    }
}
