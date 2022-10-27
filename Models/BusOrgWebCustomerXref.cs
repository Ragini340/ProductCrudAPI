using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgWebCustomerXref
    {
        public int BusOrgId { get; set; }
        public int WebCustomerTypeCdId { get; set; }
        public short PublishFlag { get; set; }
        public int? NotificationDeliveryTypeCdId { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual TypeCdDmt WebCustomerTypeCd { get; set; } = null!;
    }
}
