using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class UserIncomeApplyforcash
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public string ApplyForCashCode { get; set; }
        public decimal? ApplyForCashMoney { get; set; }
        public decimal? ApplyForCashBefore { get; set; }
        public decimal? ApplyForCashAfter { get; set; }
        public string ApplyForCashAccountType { get; set; }
        public string ApplyForCashAccountNumber { get; set; }
        public string ApplyForCashTrueName { get; set; }
        public string ApplyForCashBankName { get; set; }
        public string ApplyForCashBankBranch { get; set; }
        public DateTime? ApplyForCashDoneTime { get; set; }
        public sbyte? ApplyForCashStatus { get; set; }
        public string ApplyForCashFailReason { get; set; }
        public DateTime? ApplyForCashApplyTime { get; set; }
    }
}
