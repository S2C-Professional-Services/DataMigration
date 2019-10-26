using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2CDataMigrationConsole.Models
{
    public class MigrationUser
    {
        public int ExternalId { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public bool IsSpecialist { get; set; }
        public bool IsReceptionist { get; set; }

    }
}
