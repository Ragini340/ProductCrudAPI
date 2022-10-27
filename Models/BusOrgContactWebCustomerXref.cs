using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgContactWebCustomerXref
    {
        public int BusOrgContactId { get; set; }
        public int WebCustomerTypeCdId { get; set; }
        public short PublishFlag { get; set; }
        public int? NotificationDeliveryTypeCdId { get; set; }

        public virtual BusOrgContact BusOrgContact { get; set; } = null!;
        public virtual TypeCdDmt WebCustomerTypeCd { get; set; } = null!;
    }
}
