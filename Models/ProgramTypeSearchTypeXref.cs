using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProgramTypeSearchTypeXref
    {
        public int? ProgramTypeId { get; set; }
        public int? SearchTypeCdId { get; set; }
        public int? BusOrgId { get; set; }
        public short? IsToDefault { get; set; }
        public int ProgramTypeSearchTypeXrefId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual ProgramType? ProgramType { get; set; }
        public virtual SearchType? SearchTypeCd { get; set; }
    }
}
