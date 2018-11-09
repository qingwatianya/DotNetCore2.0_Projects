using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryGlobalArea
    {
        public int Id { get; set; }
        public string Aid { get; set; }
        public string Name { get; set; }
        public string Paid { get; set; }
        public int? OrderNumber { get; set; }
        public string Precode { get; set; }
    }
}
