using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadInEscrowDeposit
    {
        public int InEscrowId { get; set; }
        public string ClassTypeDescr { get; set; } = null!;
        public int FileId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int CreditToTypeCdId { get; set; }
        public int StatusTypeCdId { get; set; }
        public int BankAcctId { get; set; }
        public int SourceTypeCdId { get; set; }
        public int RepresentingTypeCdId { get; set; }
        public int? DepositorTypeCdId { get; set; }
        public decimal Amount { get; set; }
        public string? Comments { get; set; }
        public string ReceiptNum { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public string? Description { get; set; }
        public short? AfterHoursFlag { get; set; }
        public string? DepositTicketNum { get; set; }
        public DateTime? DepositDate { get; set; }
        public string? DepositorName { get; set; }
        public int? PaymentId { get; set; }
        public short? UpdateTrustAccountingFlag { get; set; }
        public int? ExtractId { get; set; }
        public int? AdjustedTransactionId { get; set; }
        public int? AdjustmentReasonTypeCdId { get; set; }
        public int? AdjustmentTypeCdId { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
    }
}
