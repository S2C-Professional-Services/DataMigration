using S2CDataMigrationConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2CDataMigration.Web.Models
{
    public class MigrationViewModel
    {
        public string FileName { get; set; }
        public List<MigrationUser> MigrationUsers { get; set; }
        public List<MigrationAccountHolder> MigrationAccountHolders { get; set; }
        public List<MigrationContact> MigrationContacts { get; set; }
        public List<MigrationPatient> MigrationPatients { get; set; }
        public string Message { get; set; }
      
    }
}
