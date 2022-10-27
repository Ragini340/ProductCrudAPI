using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FtpSite
    {
        public FtpSite()
        {
            CountyFtpSiteXrefs = new HashSet<CountyFtpSiteXref>();
        }

        public int FtpSiteId { get; set; }
        public string? Server { get; set; }
        public string? UserName { get; set; }
        public string Password { get; set; } = null!;
        public string BasePath { get; set; } = null!;

        public virtual ICollection<CountyFtpSiteXref> CountyFtpSiteXrefs { get; set; }
    }
}
