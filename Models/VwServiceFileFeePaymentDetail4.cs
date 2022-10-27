using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwServiceFileFeePaymentDetail4
    {
        public int ServiceFileFeeId { get; set; }
        public decimal? BuyerNonPocchargeAmtAndTaxAmt { get; set; }
        public decimal? SellerNonPocchargeAmtAndTaxAmt { get; set; }
    }
}
