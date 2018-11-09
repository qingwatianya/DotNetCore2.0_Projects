using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryOrderStatustype
    {
        public int Id { get; set; }
        public string StatusTypeCode { get; set; }
        public string StatusTypeName { get; set; }
        public string StatusTypeDesc { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
