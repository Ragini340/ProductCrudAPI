using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwServiceFileFeePaymentDetail1
    {
        public int ServiceFileFeeId { get; set; }
        public decimal BuyerChargeAmt { get; set; }
        public decimal SellerChargeAmt { get; set; }
    }
}
