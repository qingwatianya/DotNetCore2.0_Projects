using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryArticleUsetype
    {
        public int Id { get; set; }
        public string ArticleTypeCode { get; set; }
        public string ArticleTypeName { get; set; }
        public string ArticleTypeDesc { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
