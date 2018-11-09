using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class DictionaryUserGradetype
    {
        public int Id { get; set; }
        public string GradeTypeCode { get; set; }
        public string GradeTypeName { get; set; }
        public string GradeTypeDesc { get; set; }
        public int? GradeTypeBaseCondition { get; set; }
        public string GradeTypeNextGradeCode { get; set; }
        public int? GradeTypeNextGradeCondition { get; set; }
    }
}
