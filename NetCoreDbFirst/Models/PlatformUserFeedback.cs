using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformUserFeedback
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public string FeedBackContent { get; set; }
        public string FeedBackReplyContent { get; set; }
        public DateTime? FeedBackReplyTime { get; set; }
        public sbyte? FeedBackReplyIsRead { get; set; }
        public DateTime? FeedBackReplyReadTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
