using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadFileBusinessParty
    {
        public int FileBusinessPartyId { get; set; }
        public DateTime? Dwdate { get; set; }
        public int? BusOrgId { get; set; }
        public string ClassTypeDescr { get; set; } = null!;
        public int FileId { get; set; }
        public string? RoleTypeDescr { get; set; }
        public int? PrincipalId { get; set; }
        public int? BusinessUnitId { get; set; }
        public string? AttentionName { get; set; }
        public string? RefNum { get; set; }
        public int CheckDescrDetailId { get; set; }
    }
}
