using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadCountyInfo
    {
        public int CountyInfoId { get; set; }
        public int GeoRegionId { get; set; }
        public int? DefaultOwnerOfficeId { get; set; }
        public int? DefaultProductionOfficeId { get; set; }
        public short FastSearchAvailableFlag { get; set; }
    }
}
