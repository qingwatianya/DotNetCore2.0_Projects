using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class UserShortmessage
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public string Mobile { get; set; }
        public string ShortMessageTypeCode { get; set; }
        public string Content { get; set; }
        public string Desc { get; set; }
        public DateTime? SendTime { get; set; }
    }
}
