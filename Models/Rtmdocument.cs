using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Rtmdocument
    {
        public int RtmdocId { get; set; }
        public int RtmpackageId { get; set; }
        public int DocumentId { get; set; }
        public short SeqNum { get; set; }
        public int? DocTypeCdId { get; set; }
        public string? TabName { get; set; }
        public byte? NumOfCopies { get; set; }
        public bool? ColorYesNo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual TypeCdDmt? DocTypeCd { get; set; }
        public virtual Rtmpackage Rtmpackage { get; set; } = null!;
    }
}
