using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RtmfileAddress
    {
        public RtmfileAddress()
        {
            Rtmaddresses = new HashSet<Rtmaddress>();
        }

        public int RtmadhocAddrId { get; set; }
        public int? FileId { get; set; }
        public string? Name { get; set; }
        public string? AddrLine1 { get; set; }
        public string? AddrLine2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? AreaCode { get; set; }
        public string? Phone { get; set; }
        public string? Attention { get; set; }
        public string? Country { get; set; }

        public virtual ServiceFile? File { get; set; }
        public virtual ICollection<Rtmaddress> Rtmaddresses { get; set; }
    }
}
