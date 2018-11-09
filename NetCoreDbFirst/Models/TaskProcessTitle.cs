using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class TaskProcessTitle
    {
        public int Id { get; set; }
        public string Tid { get; set; }
        public string ProcessTypeCode { get; set; }
        public string ProcessTitle { get; set; }
        public string ProcessCopyData { get; set; }
        public int? PorcessOrder { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
