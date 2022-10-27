using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwFileBusinessPartyName
    {
        public int FileId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int RoleTypeCdId { get; set; }
        public string? Name { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
    }
}
