using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryUserThirdaccounttype
    {
        public long Id { get; set; }
        public string ThirdAccountTypeCode { get; set; }
        public string ThirdAccountTypeName { get; set; }
        public string Desc { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
