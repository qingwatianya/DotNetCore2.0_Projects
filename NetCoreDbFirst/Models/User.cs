using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class User
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public string ReferralCode { get; set; }
        public string UserAccount { get; set; }
        public string UserPassword { get; set; }
        public string Name { get; set; }
        public sbyte? Age { get; set; }
        public sbyte? Gender { get; set; }
        public string HeadPicUrl { get; set; }
        public string Mob { get; set; }
        public string ProvinceId { get; set; }
        public string CityId { get; set; }
        public int? AreaId { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string QqNumber { get; set; }
        public string WechatNumber { get; set; }
        public string GradeTypeCode { get; set; }
        public string UidParent { get; set; }
        public string UidTop { get; set; }
        public string UserOriginTypeCode { get; set; }
        public int? StateIsLock { get; set; }
        public string StateLockReason { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
