using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class TaskProcessTitleIllustration
    {
        public int Id { get; set; }
        public long? ProcessTitleId { get; set; }
        public string IllustrationTitle { get; set; }
        public string IllustrationDesc { get; set; }
        public string IllustrationUrl { get; set; }
        public int? IllustrationOrder { get; set; }
    }
}
