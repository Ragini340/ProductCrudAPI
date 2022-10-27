using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProjectFileSiteFileFbpxref
    {
        public int ProjectFileSiteFileFbpxrefId { get; set; }
        public int PffileBusinessPartyId { get; set; }
        public int SffileBusinessPartyId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual FileBusinessParty PffileBusinessParty { get; set; } = null!;
        public virtual FileBusinessParty SffileBusinessParty { get; set; } = null!;
    }
}
