using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SalesRepHistory
    {
        public long EventLogId { get; set; }
        public int FileId { get; set; }
        public int RoleTypeCdId { get; set; }
        public int? FromBusOrgId { get; set; }
        public int? ToBusOrgId { get; set; }
        public int? FromSalesRepId1 { get; set; }
        public int? ToSalesRepId1 { get; set; }
        public int? FromSalesRepId2 { get; set; }
        public int? ToSalesRepId2 { get; set; }

        public virtual BusOrg? FromBusOrg { get; set; }
        public virtual Employee? FromSalesRepId1Navigation { get; set; }
        public virtual Employee? FromSalesRepId2Navigation { get; set; }
        public virtual TypeCdDmt RoleTypeCd { get; set; } = null!;
        public virtual BusOrg? ToBusOrg { get; set; }
        public virtual Employee? ToSalesRepId1Navigation { get; set; }
        public virtual Employee? ToSalesRepId2Navigation { get; set; }
    }
}
