using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FractionalSsbuyerSellerAllocation
    {
        public int FractionalSsbuySelAlocId { get; set; }
        public int FileId { get; set; }
        public int RoleTypeCdId { get; set; }
        public int BuyerSellerId { get; set; }
        public decimal? VestedIntersetAllocation { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
