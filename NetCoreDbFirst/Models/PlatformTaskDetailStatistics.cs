using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformTaskDetailStatistics
    {
        public long Id { get; set; }
        public DateTime? StatisticDate { get; set; }
        public string Tid { get; set; }
        public decimal? AveragePass { get; set; }
        public int? AverageTime { get; set; }
        public long? NumberViewTotal { get; set; }
        public long? NumberAcceptTotal { get; set; }
        public long? NumberCompleteTotal { get; set; }
        public long? NumberFailTotal { get; set; }
        public long? NumberInvalidTotal { get; set; }
        public decimal? IncomePlatformTotal { get; set; }
        public decimal? IncomePlatformNetMargin { get; set; }
        public decimal? IncomeUserTotal { get; set; }
        public long? NumberDailyViewTotal { get; set; }
        public long? NumberDailyAcceptTotal { get; set; }
        public long? NumberDailyCompleteTotal { get; set; }
        public long? NumberDailyInvalidTotal { get; set; }
        public long? NumberDailyFailTotal { get; set; }
    }
}
