using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProgramTypeProductTypeXref
    {
        public int? ProgramTypeId { get; set; }
        public int? ProductTypecdId { get; set; }
        public int? BusOrgId { get; set; }
        public short? IsToDefault { get; set; }
        public int ProgramTypeProductTypeXrefId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual TypeCdDmt? ProductTypecd { get; set; }
        public virtual ProgramType? ProgramType { get; set; }
    }
}
