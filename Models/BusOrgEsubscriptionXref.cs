using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgEsubscriptionXref
    {
        public int BusOrgId { get; set; }
        public int SubscriptionTypeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int BusOrgEsubscriptionXrefId { get; set; }

        public virtual BusOrg BusOrg { get; set; } = null!;
    }
}
