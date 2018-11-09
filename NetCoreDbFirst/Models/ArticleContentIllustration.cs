using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class ArticleContentIllustration
    {
        public long Id { get; set; }
        public long? ArticleContentId { get; set; }
        public string IllustrationTitle { get; set; }
        public string IllustrationDesc { get; set; }
        public string IllustrationUrl { get; set; }
        public string IllustrationNavigateToUrl { get; set; }
        public int? IllustrationOrder { get; set; }
    }
}
