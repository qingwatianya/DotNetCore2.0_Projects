using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class OrderGradeBonus
    {
        public long Id { get; set; }
        public string Oid { get; set; }
        public string Uid { get; set; }
        public string UidParent { get; set; }
        public string UidGrandParent { get; set; }
        public string UidTop { get; set; }
        public string UidName { get; set; }
        public string UidParentName { get; set; }
        public string UidGrandParentName { get; set; }
        public string UidTopName { get; set; }
        public string UidGradeTypeCode { get; set; }
        public string UidParentGradeTypeCode { get; set; }
        public string UidGrandParentGradeTypeCode { get; set; }
        public string UidTopGradeTypeCode { get; set; }
        public decimal? UidGradeTypeBrokerageScale { get; set; }
        public decimal? UidParentGradeTypeBrokerageScale { get; set; }
        public decimal? UidGrandParentGradeTypeBrokerageScale { get; set; }
        public decimal? UidTopGradeTypeBrokerageScale { get; set; }
        public decimal? UidBonus { get; set; }
        public decimal? UidExtraBonus { get; set; }
        public decimal? UidParentBonus { get; set; }
        public decimal? UidGrandParentBonus { get; set; }
        public decimal? UidTopBonus { get; set; }
    }
}
