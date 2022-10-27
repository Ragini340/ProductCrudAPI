using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbanonAutomatedBank
    {
        public int IbabankId { get; set; }
        public string RoutingNumber { get; set; } = null!;
        public string TelegraphName { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string? State { get; set; }
        public string? City { get; set; }
        public string? FundTransferStatus { get; set; }
        public string? FundSettlementStatus { get; set; }
        public string? BookEntryStatus { get; set; }
        public DateTime? LastRevisionDate { get; set; }
        public string? BatchDate { get; set; }
        public byte[]? UpdTs { get; set; }
    }
}
