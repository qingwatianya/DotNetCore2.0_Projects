using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryTaskResourcetype
    {
        public int Id { get; set; }
        public string ResourceTypeCode { get; set; }
        public string ResourceTypeName { get; set; }
        public string ResourceTypeRemark { get; set; }
        public string ResourceTypeDesc { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
