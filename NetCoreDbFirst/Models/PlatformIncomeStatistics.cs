using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformIncomeStatistics
    {
        public long Id { get; set; }
        public DateTime? StatisticDate { get; set; }
        public decimal? IncomePlatformTotal { get; set; }
        public decimal? IncomePlatformNetMargin { get; set; }
        public decimal? IncomePlatFormApplyForCashTotal { get; set; }
        public decimal? IncomePlatFormWaitForCashTotal { get; set; }
        public decimal? IncomeUserTotal { get; set; }
        public decimal? IncomeUserDirectTotal { get; set; }
        public decimal? IncomeUserFirstLevelTotal { get; set; }
        public decimal? IncomeUserSecondLevelTotal { get; set; }
        public decimal? IncomeUserTopLevelTotal { get; set; }
        public decimal? IncomeDailyPlatformTotal { get; set; }
        public decimal? IncomeDailyPlatformNetMargin { get; set; }
        public decimal? IncomeDailyUserTotal { get; set; }
        public decimal? IncomeDailyUserDirectTotal { get; set; }
        public decimal? IncomeDailyUserFirstLevelTotal { get; set; }
        public decimal? IncomeDailyUserSecondLevelTotal { get; set; }
        public decimal? IncomeDailyUserTopLevelTotal { get; set; }
        public decimal? IncomeDailyUserFailTotal { get; set; }
    }
}
