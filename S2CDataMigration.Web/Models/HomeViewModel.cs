using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2CDataMigration.Web.Models
{
    public class HomeViewModel
    {
        public string ABNNumber { get; set; }
        public string ClientName { get; set; }
        public string MigrationType { get; set; }
        public string PhoneNumber { get; set; }
        public string ConnectionString { get; set; }
        public bool IsAdmin { get; set; }
    }
}
