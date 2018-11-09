using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformNotice
    {
        public int Id { get; set; }
        public string NoticeTitle { get; set; }
        public string NoticeContent { get; set; }
        public string NoticeNavigateToUrl { get; set; }
        public string NoticeImgUrl { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
