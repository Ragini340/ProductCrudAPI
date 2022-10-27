using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProgramTypeGeographicXref
    {
        public int? ProgramTypeId { get; set; }
        public int? GeoClassTypeCdId { get; set; }
        public int? GeoRegionId { get; set; }
        public int? BusOrgId { get; set; }
        public int ProgramTypeGeographicXrefId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual TypeCdDmt? GeoClassTypeCd { get; set; }
        public virtual GeographicRegion? GeoRegion { get; set; }
        public virtual ProgramType? ProgramType { get; set; }
    }
}
