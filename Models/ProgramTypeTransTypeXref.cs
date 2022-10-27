using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProgramTypeTransTypeXref
    {
        public int? ProgramTypeId { get; set; }
        public int? TransTypecdId { get; set; }
        public int? BusOrgId { get; set; }
        public short IsToDefault { get; set; }
        public int ProgramTypeTransTypeXrefId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual ProgramType? ProgramType { get; set; }
        public virtual TypeCdDmt? TransTypecd { get; set; }
    }
}
