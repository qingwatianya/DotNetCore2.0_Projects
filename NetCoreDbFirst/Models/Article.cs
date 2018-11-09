using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class Article
    {
        public int Id { get; set; }
        public string Aid { get; set; }
        public string ArticleTypeCode { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleDesc { get; set; }
        public string ArticleNavigateToUrl { get; set; }
        public int? ArticleIsShow { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
