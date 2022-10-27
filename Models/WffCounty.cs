using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WffCounty
    {
        public WffCounty()
        {
            WffGeoLocations = new HashSet<WffGeoLocation>();
        }

        public int CountyId { get; set; }
        public int? GeoCountyId { get; set; }
        public string? CountyName { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual GeographicRegion? GeoCounty { get; set; }
        public virtual ICollection<WffGeoLocation> WffGeoLocations { get; set; }
    }
}
