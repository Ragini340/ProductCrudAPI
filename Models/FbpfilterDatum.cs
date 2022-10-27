using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FbpfilterDatum
    {
        public int FileBusinessPartyId { get; set; }
        public int? Fileid { get; set; }
        public int? BusOrgId { get; set; }
        public int? RoleTypeCdId { get; set; }
        public int? OriginalBusOrgId { get; set; }
    }
}
