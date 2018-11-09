using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class TaskResourceSubmitrequest
    {
        public int Id { get; set; }
        public string Tid { get; set; }
        public string ResourceTypeCode { get; set; }
        public string ResourceTypeName { get; set; }
        public string ResourceTypeRemark { get; set; }
        public int? RequestNumber { get; set; }
        public int? RequestOrder { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
