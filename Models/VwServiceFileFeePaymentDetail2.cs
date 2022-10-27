using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwServiceFileFeePaymentDetail2
    {
        public int ServiceFileFeeId { get; set; }
        public decimal BuyerChargeAmt { get; set; }
        public decimal SellerChargeAmt { get; set; }
        public decimal BuyerSalesTaxAmt { get; set; }
        public decimal SellerSalesTaxAmt { get; set; }
        public decimal Poclender { get; set; }
        public decimal Pocmb { get; set; }
        public decimal Poc { get; set; }
        public decimal Pocb { get; set; }
        public decimal Pocs { get; set; }
        public decimal BuyerNonPocchargeAmt { get; set; }
        public decimal SellerNonPocchargeAmt { get; set; }
        public decimal BuyerNonPocsalesTaxAmt { get; set; }
        public decimal SellerNonPocsalesTaxAmt { get; set; }
        public decimal PoclenderBuyerChargeOnly { get; set; }
        public decimal PoclenderSellerChargeOnly { get; set; }
        public decimal PocmbbuyerChargeOnly { get; set; }
        public decimal PocmbsellerChargeOnly { get; set; }
        public decimal PocforBuyerOnly { get; set; }
        public decimal PocforSellerOnly { get; set; }
        public decimal PocbforBuyerOnly { get; set; }
        public decimal PocbforSellerOnly { get; set; }
        public decimal PocsforBuyerOnly { get; set; }
        public decimal PocsforSellerOnly { get; set; }
        public decimal TotalBuyerPocchargeAmt { get; set; }
        public decimal TotalBuyerPocsalesTaxAmt { get; set; }
        public decimal TotalSellerPocchargeAmt { get; set; }
        public decimal TotalSellerPocsalesTaxAmt { get; set; }
        public decimal TotalPocchargeAmt { get; set; }
    }
}
