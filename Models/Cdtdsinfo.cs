using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Cdtdsinfo
    {
        public int CdtdsinfoId { get; set; }
        public int? TitleEscrowInfoId { get; set; }
        public DateTime? DateIssued { get; set; }
        public byte? DateReceivedAck { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? ClosingDate { get; set; }
        public byte? DeliveryType { get; set; }
        public byte? LenderIssuedProvided { get; set; }
        public int? StatementTypeCdId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public DateTime? DisbursementDate { get; set; }
        public byte? LenderIssuedProvidedBeforeClosing { get; set; }
        public byte? LenderIssuedProvidedAfterClosing { get; set; }

        public virtual TitleEscrowInfo? TitleEscrowInfo { get; set; }
    }
}
