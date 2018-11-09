using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryTaskTagtype
    {
        public int Id { get; set; }
        public string TagTypeCode { get; set; }
        public string TagTypeName { get; set; }
        public string TagTypeDesc { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
