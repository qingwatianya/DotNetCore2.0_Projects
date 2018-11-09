using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class UserThirdaccountid
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public string ThirdAccountTypeCode { get; set; }
        public string ThirdAccountTypeId { get; set; }
        public string AccessToken { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
