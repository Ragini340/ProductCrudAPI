using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadGeographicRegion
    {
        public int GeoRegionId { get; set; }
        public string? ObjectCd { get; set; }
        public string? StateName { get; set; }
        public string? CountyName { get; set; }
        public string? CityName { get; set; }
    }
}
