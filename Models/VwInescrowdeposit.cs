using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwInescrowdeposit
    {
        public long SmstranslogId { get; set; }
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int InEscrowId { get; set; }
        public string ReceiptNum { get; set; } = null!;
        public decimal Amount { get; set; }
        public string FileNum { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public int CreditToTypeCdId { get; set; }
        public short? AfterHoursFlag { get; set; }
        public int? AdjustmentTypeCdId { get; set; }
        public int? AdjustedTransactionId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int SourceTypeCdId { get; set; }
        public int StatusTypeCdId { get; set; }
        public string? Description { get; set; }
        public string? AccountNum { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? DepositorName { get; set; }
        public string? Abanum { get; set; }
        public string? SmsbankCd { get; set; }
        public string? Name1 { get; set; }
        public string? ObjectCd { get; set; }
        public string? Descr { get; set; }
        public short? ManualReceiptFlag { get; set; }
        public string? RoutingNum { get; set; }
        public string? ManualReceiptReason { get; set; }
        public int? AdjustmentReasonTypeCdId { get; set; }
        public string? Comments { get; set; }
        public string? BankName { get; set; }
        public int? CorrectingTransactionId { get; set; }
        public string? AdjreceiptNum { get; set; }
        public DateTime? AdjissueDate { get; set; }
        public decimal? Adjamount { get; set; }
        public string? Adjdescription { get; set; }
        public string? Adjcomments { get; set; }
        public int? AdjclassTypeId { get; set; }
        public string? MemsmsbankCd { get; set; }
        public string? Memname1 { get; set; }
        public string? MemaccountNum { get; set; }
        public int? MemdepositorTypeCdId { get; set; }
        public int? DepositorTypeCdId { get; set; }
        public int RepresentingTypecdId { get; set; }
        public string? CrFileNum { get; set; }
        public string? NewDepositor { get; set; }
        public string? OldDepositor { get; set; }
        public short? IsExchangeRegionFlag { get; set; }
    }
}
