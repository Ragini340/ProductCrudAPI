using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadCharge
    {
        public int ChargeId { get; set; }
        public string ClassTypeDescr { get; set; } = null!;
        public int FileId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int ChargeProcessTypeCdId { get; set; }
        public int ChargeCategoryTypeCdId { get; set; }
        public int? BuyerPaymentMethodTypeCdId { get; set; }
        public int? SellerPaymentMethodTypeCdId { get; set; }
        public int EscrowChargeTemplateId { get; set; }
        public decimal Amount { get; set; }
        public int FileProcessId { get; set; }
        public int? InterestTypeCdId { get; set; }
        public int? PaymentTermTypeCdId { get; set; }
        public string? Comments { get; set; }
        public int StatusTypeCdId { get; set; }
        public int SourceTypeCdId { get; set; }
        public string? Description { get; set; }
        public string? ChargeCd { get; set; }
        public int SeqNum { get; set; }
        public decimal BuyerChargeAmount { get; set; }
        public decimal BuyerCreditAmount { get; set; }
        public decimal SellerChargeAmount { get; set; }
        public decimal SellerCreditAmount { get; set; }
        public decimal FileChargeAmount { get; set; }
        public decimal FileCreditAmount { get; set; }
        public int FileBusinessPartyId { get; set; }
        public string? PayeeName { get; set; }
        public decimal? BasisAmount { get; set; }
        public decimal? AnnualInterestRate { get; set; }
        public decimal? PerDiemAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public short? FromDateInclusiveFlag { get; set; }
        public short? FromDateIsProrateDateFlag { get; set; }
        public DateTime? ToDate { get; set; }
        public short? ToDateInclusiveFlag { get; set; }
        public short? ToDateIsProrateDateFlag { get; set; }
        public int? CalendarBasisDays { get; set; }
        public short? UserOverrideFlag { get; set; }
        public short? UsePerDiemFlag { get; set; }
        public short? CreditSellerFlag { get; set; }
        public short? DayOfClosePaidBySellerFlag { get; set; }
        public int? Months { get; set; }
        public decimal? MonthlyChargeAmount { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
    }
}
