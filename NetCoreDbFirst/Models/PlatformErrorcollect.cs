using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformErrorcollect
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public string ErrorTypeCode { get; set; }
        public string ErrorDevice { get; set; }
        public string ErrorTitle { get; set; }
        public string ErrorContent { get; set; }
        public DateTime? CollectTime { get; set; }
    }
}
