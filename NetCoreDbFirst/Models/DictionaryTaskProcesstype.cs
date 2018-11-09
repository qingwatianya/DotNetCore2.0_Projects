using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryTaskProcesstype
    {
        public int Id { get; set; }
        public string ProcessTypeCode { get; set; }
        public string ProcessTypeName { get; set; }
        public string Desc { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
