using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformOrderStatistics
    {
        public long Id { get; set; }
        public DateTime? StatisticDate { get; set; }
        public int? NumberTotal { get; set; }
        public int? NumberCompleteTotal { get; set; }
        public int? NumberFailTotal { get; set; }
        public int? NumberEffectiveTotal { get; set; }
        public int? NumberInvalidTotal { get; set; }
        public int? NumberUnReview { get; set; }
        public int? NumberDailyAdd { get; set; }
        public int? NumberDailyComplete { get; set; }
        public int? NumberDailyFail { get; set; }
        public int? NumberDailyInvalid { get; set; }
    }
}
