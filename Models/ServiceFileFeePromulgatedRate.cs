using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileFeePromulgatedRate
    {
        public int ServiceFileFeeId { get; set; }
        public decimal? BuyerPromulgatedRate { get; set; }
        public decimal? SellerPromulgatedRate { get; set; }

        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
    }
}
