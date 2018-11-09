using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class ArticleContent
    {
        public long Id { get; set; }
        public string Aid { get; set; }
        public string ContentTitle { get; set; }
        public string ContentContent { get; set; }
        public string ContentNavigateToUrl { get; set; }
        public int? ContentOrder { get; set; }
    }
}
