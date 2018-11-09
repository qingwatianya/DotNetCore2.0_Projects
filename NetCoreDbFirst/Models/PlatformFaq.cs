using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class PlatformFaq
    {
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionContent { get; set; }
        public string QuestionAnswer { get; set; }
        public long? QuestionViewTimes { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
