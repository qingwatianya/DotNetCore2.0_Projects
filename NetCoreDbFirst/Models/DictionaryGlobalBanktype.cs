using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryGlobalBanktype
    {
        public int Id { get; set; }
        public string BankTypeCode { get; set; }
        public string BankTypeName { get; set; }
        public string BankTypeDesc { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
