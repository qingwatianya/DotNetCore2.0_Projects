using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class UserFansStatistics
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public int? FansFirstLevelNumber { get; set; }
        public int? FansSecondLevelNumber { get; set; }
        public int? FansTopLevelNumber { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
