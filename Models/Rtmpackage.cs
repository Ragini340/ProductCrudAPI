using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Rtmpackage
    {
        public Rtmpackage()
        {
            Rtmaddresses = new HashSet<Rtmaddress>();
            Rtmdocuments = new HashSet<Rtmdocument>();
        }

        public int RtmpackageId { get; set; }
        public int FileId { get; set; }
        public string Descr { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual ICollection<Rtmaddress> Rtmaddresses { get; set; }
        public virtual ICollection<Rtmdocument> Rtmdocuments { get; set; }
    }
}
