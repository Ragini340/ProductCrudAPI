using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CountyFtpSiteXref
    {
        public int GeoRegionId { get; set; }
        public int FtpSiteId { get; set; }
        public string State { get; set; } = null!;
        public string County { get; set; } = null!;
        public string? FtpSubPath { get; set; }

        public virtual FtpSite FtpSite { get; set; } = null!;
    }
}
