using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WffCountry
    {
        public WffCountry()
        {
            WffGeoLocations = new HashSet<WffGeoLocation>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public byte[]? UpdTs { get; set; }

        public virtual ICollection<WffGeoLocation> WffGeoLocations { get; set; }
    }
}
