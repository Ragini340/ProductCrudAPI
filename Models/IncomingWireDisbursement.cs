using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IncomingWireDisbursement
    {
        public int DisbursementId { get; set; }
        public decimal? Amount { get; set; }
        public int IncomingWireDetailId { get; set; }
        public int WireDisbursementDetailId { get; set; }
        public DateTime? IssueDate { get; set; }
        public int? DisbursementMethodTypeCdId { get; set; }
        public int? BankAcctId { get; set; }
        public int? SourceTypeCdId { get; set; }
        public int? StatusTypeCdId { get; set; }
        public int? IssuedByEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public string? DocumentNum { get; set; }

        public virtual IncomingWireDetail IncomingWireDetail { get; set; } = null!;
        public virtual Employee? UpdatedEmployee { get; set; }
        public virtual WireDisbursementDetail WireDisbursementDetail { get; set; } = null!;
    }
}
