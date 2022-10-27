using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SimulatorFbpfilterDatum
    {
        public int FileBusinessPartyId { get; set; }
        public int Fileid { get; set; }
        public string? Name { get; set; }
        public int? BusOrgId { get; set; }
        public int? RoleTypeCdId { get; set; }
        public byte[]? Updts { get; set; }
    }
}
