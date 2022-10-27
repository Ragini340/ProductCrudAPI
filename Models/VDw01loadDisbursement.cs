using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadDisbursement
    {
        public int DisbursementId { get; set; }
        public string ClassTypeDescr { get; set; } = null!;
        public int FileId { get; set; }
        public int? TransactionTypeCdId { get; set; }
        public int? StatusTypeCdId { get; set; }
        public decimal? Amount { get; set; }
        public string? Comments { get; set; }
        public int? FileProcessId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int? SourceTypeCdId { get; set; }
        public string? Description { get; set; }
        public string? Reference { get; set; }
        public int? SeqNum { get; set; }
        public int? BankAcctId { get; set; }
        public string? PayeeName { get; set; }
        public int? HoldForDays { get; set; }
        public DateTime? HoldUntilDate { get; set; }
        public string? HoldPurpose { get; set; }
        public DateTime? HoldDate { get; set; }
        public int? HeldByEmployeeId { get; set; }
        public DateTime? IssueDate { get; set; }
        public int? DisbursementMethodTypeCdId { get; set; }
        public int? IssuedByEmployeeId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByEmployeeId { get; set; }
        public string? VoucherMemo { get; set; }
        public string? VoucherChargeDetails { get; set; }
        public string? VoucherDescription { get; set; }
        public string? DocumentNum { get; set; }
        public int? WireDisbursementDetailId { get; set; }
        public short? UpdateTrustAccountingFlag { get; set; }
        public int? TasupdateDate { get; set; }
        public short? ManualCheckFlag { get; set; }
        public DateTime? SplitDate { get; set; }
        public int? SplitByEmployeeId { get; set; }
        public int? AdjustmentReasonTypeCdId { get; set; }
        public int? AdjustmentTypeCdId { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public int? CorrectingTransactionId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public int? FileFeeDisbursementCauseTypeCdId { get; set; }
    }
}
