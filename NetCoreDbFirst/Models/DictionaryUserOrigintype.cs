using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryUserOrigintype
    {
        public int Id { get; set; }
        public string OriginTypeCode { get; set; }
        public string OriginTypeName { get; set; }
        public string Desc { get; set; }
    }
}
