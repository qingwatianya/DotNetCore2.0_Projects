using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class Efmigrationshistory
    {
        public string MigrationId { get; set; }
        public string ProductVersion { get; set; }
    }
}
