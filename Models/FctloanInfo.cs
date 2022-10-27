using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FctloanInfo
    {
        public int FileProcessId { get; set; }
        public int? MortgageProductTypeCdId { get; set; }
        public int? ProductOptionTypeCdId { get; set; }
        public short? ConstructionMortgage { get; set; }
        public short? AssignmentRents { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? BaseRate { get; set; }
        public decimal? PlusMinusRate { get; set; }
        public decimal? EquivalentRate { get; set; }
        public decimal? MaxChargeRate { get; set; }
        public DateTime? LastPaymentDue { get; set; }
        public DateTime? AgreementDate { get; set; }
        public string? PaymentDatePeriod { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual TypeCdDmt? MortgageProductTypeCd { get; set; }
        public virtual TypeCdDmt? ProductOptionTypeCd { get; set; }
    }
}
