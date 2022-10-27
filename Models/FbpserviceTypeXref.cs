using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FbpserviceTypeXref
    {
        public int FbpserviceTypeXrefId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int ServiceTypeId { get; set; }
        public string? Comments { get; set; }

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
        public virtual TypeCdDmt ServiceType { get; set; } = null!;
    }
}
