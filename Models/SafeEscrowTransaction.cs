using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SafeEscrowTransaction
    {
        public int SafeEscrowTranId { get; set; }
        public int FileId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int StatusCdId { get; set; }
        public DateTime? OrderedDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string? SafeEscrowId { get; set; }
        public byte? FinalLedger { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? DisbursementGuid { get; set; }
        public string? PayeeName { get; set; }
        public string? RefCkNumber { get; set; }
        public DateTime? ClearedDate { get; set; }
        public int? FileProcessId { get; set; }
        public decimal? Amount { get; set; }
        public string? DocumentType { get; set; }
    }
}
