using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WffState
    {
        public WffState()
        {
            WffGeoLocations = new HashSet<WffGeoLocation>();
        }

        public int StateId { get; set; }
        public int? GeoStateId { get; set; }
        public string? StateName { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual GeographicRegion? GeoState { get; set; }
        public virtual ICollection<WffGeoLocation> WffGeoLocations { get; set; }
    }
}
