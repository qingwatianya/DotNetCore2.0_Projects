using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class OrderStatusDetail
    {
        public long Id { get; set; }
        public string Oid { get; set; }
        public string StatusTypeCode { get; set; }
        public string Remark { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
