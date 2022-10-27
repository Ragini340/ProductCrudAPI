using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WffGeoLocation
    {
        public WffGeoLocation()
        {
            WffGeoFilters = new HashSet<WffGeoFilter>();
        }

        public int GeoLocationId { get; set; }
        public int CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CountyId { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual WffCountry Country { get; set; } = null!;
        public virtual WffCounty? County { get; set; }
        public virtual WffState? State { get; set; }
        public virtual ICollection<WffGeoFilter> WffGeoFilters { get; set; }
    }
}
