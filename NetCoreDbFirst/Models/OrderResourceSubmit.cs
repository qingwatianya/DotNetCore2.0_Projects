using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class OrderResourceSubmit
    {
        public long Id { get; set; }
        public string Oid { get; set; }
        public string PicArray { get; set; }
        public string RegistAccount { get; set; }
        public string RegistMobile { get; set; }
        public string RegistName { get; set; }
        public string SubmitContent { get; set; }
        public string Remark { get; set; }
        public DateTime? SubmitTime { get; set; }
    }
}
