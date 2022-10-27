using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GfeloanTerm
    {
        public GfeloanTerm()
        {
            GfeimpoundDescriptions = new HashSet<GfeimpoundDescription>();
        }

        public int GfeloanTermId { get; set; }
        public int FileId { get; set; }
        public decimal? InitialLoanAmt { get; set; }
        public string? LoanTerm { get; set; }
        public double? InitialIntRate { get; set; }
        public string? InitialMonthlyAmt { get; set; }
        public short? InitialMonthlyPrnFlag { get; set; }
        public short? InitialMonthlyIntFlag { get; set; }
        public short? InitialMonthlyMinsAmtFlag { get; set; }
        public short? IntRateIncrFlag { get; set; }
        public double? MaxIntRate { get; set; }
        public DateTime? IntRateChangeDate { get; set; }
        public string? IntRateBeforePeriod { get; set; }
        public string? IntRateAfterPeriod { get; set; }
        public string? ChangedIntRate { get; set; }
        public double? LowerIntRate { get; set; }
        public double? HigherIntRate { get; set; }
        public short? LoanBalIncrFlag { get; set; }
        public string? LoanBalMaxAmt { get; set; }
        public short? MonthlyAmtIncrFlag { get; set; }
        public DateTime? MonthlyAmtChangeDate { get; set; }
        public decimal? MonthlyIncrAmt { get; set; }
        public decimal? MonthlyMaxAmt { get; set; }
        public short? PrePaymentFlag { get; set; }
        public decimal? PrePaymentMaxAmt { get; set; }
        public short? BalloonPaymentFlag { get; set; }
        public decimal? BalloonPaymentMaxAmt { get; set; }
        public short? BalloonPaymentDuePeriod { get; set; }
        public DateTime? BalloonPaymentDueDate { get; set; }
        public short? TotalMonthlyAmtFlag { get; set; }
        public short? AddlMonthlyEscrowAmtFlag { get; set; }
        public string? AddlMonthlyEscrowAmt { get; set; }
        public string? TotalInitialMonthlyAmt { get; set; }
        public DateTime? CreationDate { get; set; }
        public byte? StatusCd { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual ICollection<GfeimpoundDescription> GfeimpoundDescriptions { get; set; }
    }
}
