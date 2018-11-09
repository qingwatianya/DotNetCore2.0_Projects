using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class UserMsgbox
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public string MsgTypeCode { get; set; }
        public string MsgTitle { get; set; }
        public string MsgContent { get; set; }
        public int? MsgIsRead { get; set; }
        public string MsgRelationId { get; set; }
        public DateTime? MsgReadTime { get; set; }
        public string MsgRemark { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
