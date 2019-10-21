using System;
using System.Collections.Generic;
using System.Net;

namespace S2CDataMigration.Models
{
    public partial class AccessEvents
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public IPAddress Ip { get; set; }
        public string User { get; set; }
        public string SessionId { get; set; }
        public string Params { get; set; }
        public string Env { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
