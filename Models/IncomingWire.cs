using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IncomingWire
    {
        public IncomingWire()
        {
            IncomingWireDetails = new HashSet<IncomingWireDetail>();
        }

        public int IncomingWireId { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string? Bai2RefsResponse { get; set; }
        public int? Status { get; set; }
        public string? Bai2TextResponse { get; set; }
        public int? BankUserRepId { get; set; }
        public int? SourceTypeCdId { get; set; }

        public virtual TypeCdDmt? SourceTypeCd { get; set; }
        public virtual ICollection<IncomingWireDetail> IncomingWireDetails { get; set; }
    }
}
