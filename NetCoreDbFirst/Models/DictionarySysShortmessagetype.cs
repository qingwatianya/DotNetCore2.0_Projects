using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionarySysShortmessagetype
    {
        public int Id { get; set; }
        public string ShortMessageTypeCode { get; set; }
        public string ShortMessageTypeName { get; set; }
        public string Desc { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
