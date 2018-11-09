using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class Version
    {
        public int Id { get; set; }
        public string VersionId { get; set; }
        public string VersionType { get; set; }
        public string VersionContent { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
