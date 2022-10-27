using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WireHistory
    {
        public int WireHistoryId { get; set; }
        public int? WireTypeCdid { get; set; }
        public int? WireDisbursementDetailId { get; set; }
        public int? FileId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual WireDisbursementDetail? WireDisbursementDetail { get; set; }
        public virtual TypeCdDmt? WireTypeCd { get; set; }
    }
}
