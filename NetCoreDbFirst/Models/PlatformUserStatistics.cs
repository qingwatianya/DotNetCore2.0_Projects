using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformUserStatistics
    {
        public long Id { get; set; }
        public DateTime? StatisticDate { get; set; }
        public int? NumberDailyRegister { get; set; }
        public int? NumberTotal { get; set; }
        public int? NumberD { get; set; }
        public int? NumberC1 { get; set; }
        public int? NumberC2 { get; set; }
        public int? NumberC3 { get; set; }
        public int? NumberC4 { get; set; }
        public int? NumberC5 { get; set; }
        public int? NumberB1 { get; set; }
        public int? NumberB2 { get; set; }
        public int? NumberB3 { get; set; }
        public int? NumberB4 { get; set; }
        public int? NumberB5 { get; set; }
        public int? NumberA1 { get; set; }
        public int? NumberA2 { get; set; }
        public int? NumberA3 { get; set; }
        public int? NumberA4 { get; set; }
        public int? NumberA5 { get; set; }
    }
}
