using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class Order
    {
        public long Id { get; set; }
        public string Oid { get; set; }
        public string Tid { get; set; }
        public string Uid { get; set; }
        public string StatusTypeCode { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public DateTime? EffectiveEndTime { get; set; }
    }
}
