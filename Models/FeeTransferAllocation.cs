using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FeeTransferAllocation
    {
        public int DisbursementAllocationId { get; set; }
        public int DisbursementId { get; set; }
        public decimal? BuyerChargeAmount { get; set; }
        public decimal? SellerChargeAmount { get; set; }
        public int FeeId { get; set; }
        public short? FeeToBucket { get; set; }
        public decimal? BuyerSalesTaxAmt { get; set; }
        public decimal? SellerSalesTaxAmt { get; set; }
        public int? SplitFeeFlag { get; set; }
        public decimal? SplitAmt { get; set; }
        public int? FeeTypeCdId { get; set; }
        public int? GllookupId { get; set; }
        public int? InvoiceId { get; set; }
        public int? FileTransactionTypeCdId { get; set; }
        public int? FileProcessId { get; set; }
        public int? PaymentMethodTypeCdId { get; set; }
        public short? CompanyIncomeFee { get; set; }
        public short? OfficeIncomeFee { get; set; }
        public short? TitleOfficerFee { get; set; }
        public short? EscrowOfficerFee { get; set; }
        public short? SalesRepFee { get; set; }
        public short? PremiumSalesTaxFlag { get; set; }
        public short? Otcflag { get; set; }
        public short? PromulgatedFee { get; set; }
        public short? RemittanceFee { get; set; }
        public short? GovernmentReportableFlag { get; set; }
        public short? RateTypeFlag { get; set; }
        public short? TransactionCodeFlag { get; set; }
        public int? TransactionTypeId { get; set; }
        public int? FeeOwningOfficeTypeCdId { get; set; }
        public int? FeeOwningOfficeBuid { get; set; }
        public decimal? BuyerPaidChargeAmt { get; set; }
        public decimal? BuyerPaidSalesTaxAmt { get; set; }
        public decimal? SellerPaidChargeAmt { get; set; }
        public decimal? SellerPaidSalesTaxAmt { get; set; }
        public int? ServiceFileFeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public decimal? ExchangeFeeAmt { get; set; }

        public virtual Disbursement Disbursement { get; set; } = null!;
        public virtual DisbursementAllocation DisbursementAllocation { get; set; } = null!;
        public virtual Fee Fee { get; set; } = null!;
    }
}
