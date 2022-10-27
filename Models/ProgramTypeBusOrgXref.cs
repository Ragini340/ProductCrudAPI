using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProgramTypeBusOrgXref
    {
        public int? ProgramTypeId { get; set; }
        public int? BusOrgId { get; set; }
        public decimal? MaxLiabilityAmount { get; set; }
        public int ProgramTypeBusOrgXrefId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual ProgramType? ProgramType { get; set; }
    }
}
