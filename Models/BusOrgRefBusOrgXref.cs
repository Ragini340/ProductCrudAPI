using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgRefBusOrgXref
    {
        public int BusOrgRefBusOrgXrefId { get; set; }
        public int OriginalBusOrgId { get; set; }
        public int ReferenceBusOrgId { get; set; }

        public virtual BusOrg OriginalBusOrg { get; set; } = null!;
        public virtual BusOrg ReferenceBusOrg { get; set; } = null!;
    }
}
