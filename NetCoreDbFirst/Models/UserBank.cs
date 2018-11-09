using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class UserBank
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public string UserTrueName { get; set; }
        public string AccountTypeCode { get; set; }
        public string AccountTypeNumber { get; set; }
        public string AccountTypeBankName { get; set; }
        public string AccountTypeBankBranch { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
