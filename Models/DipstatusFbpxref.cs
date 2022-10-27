using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DipstatusFbpxref
    {
        public int FileBusinessPartyId { get; set; }
        public short Dipstatus { get; set; }
        public string? AgentLicNo { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
    }
}
