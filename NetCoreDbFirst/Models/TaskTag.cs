using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class TaskTag
    {
        public long Id { get; set; }
        public string Tid { get; set; }
        public string TagTypeCode { get; set; }
        public string TagContent { get; set; }
        public int? TagOrder { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
