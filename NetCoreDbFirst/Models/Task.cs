using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Tid { get; set; }
        public string TaskName { get; set; }
        public string TaskContent { get; set; }
        public string TaskIconLink { get; set; }
        public string TaskRecommendLink { get; set; }
        public string TaskQrcodeLink { get; set; }
        public string TaskRefferalCode { get; set; }
        public string TaskDesc { get; set; }
        public DateTime? TaskStartDate { get; set; }
        public DateTime? TaskEndDate { get; set; }
        public string TaskCompany { get; set; }
        public string TaskCompanyDesc { get; set; }
        public string TaskRemark { get; set; }
        public sbyte? TaskIsShow { get; set; }
        public decimal? TaskBonusFrom { get; set; }
        public decimal? TaskBonusTo { get; set; }
        public decimal? TaskBonusUserExtra { get; set; }
        public decimal? TaskBonusPlatform { get; set; }
        public int? TaskEffectiveTimeAfterAccept { get; set; }
        public string TaskDifficultyType { get; set; }
        public int? TaskAverageTime { get; set; }
        public decimal? TaskAveragePass { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
