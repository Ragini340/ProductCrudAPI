using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwServiceFileFeePaymentDetailPocSupp
    {
        public int Fileid { get; set; }
        public short? Hud1buyercharge { get; set; }
        public short? Hud1sellercharge { get; set; }
        public decimal TotPoclender { get; set; }
        public int PoclenderFlg { get; set; }
        public decimal TotPoclenderBuyerOnly { get; set; }
        public int PoclenderFlgBuyerOnly { get; set; }
        public decimal TotPoclenderSellerOnly { get; set; }
        public int PoclenderFlgSellerOnly { get; set; }
        public decimal TotPocmb { get; set; }
        public int Pocmbflg { get; set; }
        public decimal TotPocmbbuyerOnly { get; set; }
        public int PocmbflgBuyerOnly { get; set; }
        public decimal TotPocmbsellerOnly { get; set; }
        public int PocmbflgSellerOnly { get; set; }
        public decimal TotPoc { get; set; }
        public int Pocflg { get; set; }
        public decimal TotPocbuyerOnly { get; set; }
        public int PocflgBuyerOnly { get; set; }
        public decimal TotPocsellerOnly { get; set; }
        public int PocflgSellerOnly { get; set; }
        public decimal TotPocb { get; set; }
        public int Pocbflg { get; set; }
        public decimal TotPocbbuyerOnly { get; set; }
        public int PocbflgBuyerOnly { get; set; }
        public decimal TotPocbsellerOnly { get; set; }
        public int PocbflgSellerOnly { get; set; }
        public decimal TotPocs { get; set; }
        public int Pocsflg { get; set; }
        public decimal TotPocsbuyerOnly { get; set; }
        public int PocsflgBuyerOnly { get; set; }
        public decimal TotPocssellerOnly { get; set; }
        public int PocsflgSellerOnly { get; set; }
    }
}
