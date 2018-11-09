using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class TaskStock
    {
        public int Id { get; set; }
        public string Tid { get; set; }
        public int? TaskTotalNumber { get; set; }
        public int? TaskAvailableNumber { get; set; }
        public int? TaskDoneNumber { get; set; }
        public int? TaskCompleteNumber { get; set; }
        public int? TaskOnePersonLimitNumber { get; set; }
        public int? TaskIsOver { get; set; }
        public string TaskOverReason { get; set; }
        public DateTime? TaskOverTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
