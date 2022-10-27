using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileUnderwriterXref
    {
        public int FileId { get; set; }
        public int OfficeUnderwriterId { get; set; }
        public int RegionUnderwriterId { get; set; }
        public int TitleOwnerOfficeId { get; set; }
        public int? PolicyIssuerTypeId { get; set; }
        public int? UwemployeeId { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual OfficeUnderwriter OfficeUnderwriter { get; set; } = null!;
        public virtual RegionUnderwriter RegionUnderwriter { get; set; } = null!;
        public virtual BusinessUnit TitleOwnerOffice { get; set; } = null!;
    }
}
