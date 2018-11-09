using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformTaskStatistics
    {
        public long Id { get; set; }
        public DateTime? StatisticDate { get; set; }
        public int? NumberTotal { get; set; }
        public int? NumberActive { get; set; }
        public int? NumberInvalid { get; set; }
        public int? NumberDailyAdd { get; set; }
        public long? NumberViewTotal { get; set; }
    }
}
