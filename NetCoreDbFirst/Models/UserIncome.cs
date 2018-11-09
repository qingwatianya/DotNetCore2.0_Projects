using System;
using System.Collections.Generic;

namespace NetCoreDbFirst.Models
{
    public partial class UserIncome
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public decimal? AccountTotalIncome { get; set; }
        public decimal? AccountTotalWithdrawCash { get; set; }
        public decimal? AccountBalance { get; set; }
        public decimal? TotalIncomeFirstLevel { get; set; }
        public decimal? TotalIncomeSecondLevel { get; set; }
        public decimal? TotalIncomeTopLevel { get; set; }
        public decimal? IncomeOnTheWay { get; set; }
        public decimal? IncomeUnderReview { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
