using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WffGeoFilter
    {
        public int GeoFilterId { get; set; }
        public int GeoLocationId { get; set; }
        public int WorkFlow2Id { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual WffGeoLocation GeoLocation { get; set; } = null!;
    }
}
