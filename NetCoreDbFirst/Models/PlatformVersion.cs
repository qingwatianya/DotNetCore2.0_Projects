using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformVersion
    {
        public int Id { get; set; }
        public string VersionProgramTypeCode { get; set; }
        public int? VersionOrder { get; set; }
        public string VersionCodeLocal { get; set; }
        public string VersionCodeServer { get; set; }
        public string VersionContent { get; set; }
        public string VersionContentRemark { get; set; }
        public DateTime? VersionUpdateTime { get; set; }
    }
}
