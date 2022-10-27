using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InEscrowDeposit
    {
        public InEscrowDeposit()
        {
            Ibatransactions = new HashSet<Ibatransaction>();
            InverseAdjustedTransaction = new HashSet<InEscrowDeposit>();
            InverseCorrectingTransaction = new HashSet<InEscrowDeposit>();
            InverseDlparentInEscrow = new HashSet<InEscrowDeposit>();
            OverDraftInEscrowDepositLinks = new HashSet<OverDraftInEscrowDepositLink>();
            OverDraftInEscrowDepositXrefs = new HashSet<OverDraftInEscrowDepositXref>();
            ProjectFileSiteFileDepositXrefPfinEscrows = new HashSet<ProjectFileSiteFileDepositXref>();
            ProjectFileSiteFileDepositXrefSfinEscrows = new HashSet<ProjectFileSiteFileDepositXref>();
            WireReceipts = new HashSet<WireReceipt>();
        }

        public int InEscrowId { get; set; }
        public int ClassTypeId { get; set; }
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
        public int? AdjustmentReasonTypeCdId { get; set; }
        public int? AdjustmentTypeCdId { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public int? CorrectingTransactionId { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? AdjustedTransactionId { get; set; }
        public int? DepositListId { get; set; }
        public int? ExcludeFlag { get; set; }
        public string? ExcludeReason { get; set; }
        public int? ExcludeEmployeeId { get; set; }
        public DateTime? ExcludeDate { get; set; }
        public int? DlparentInEscrowId { get; set; }
        public short? ManualReceiptFlag { get; set; }
        public string? ManualReceiptReason { get; set; }
        public int? PropertyId { get; set; }
        public decimal? RemainingAmount { get; set; }
        public short? TreatAsOtherFlag { get; set; }

        public virtual InEscrowDeposit? AdjustedTransaction { get; set; }
        public virtual TypeCdDmt? AdjustmentReasonTypeCd { get; set; }
        public virtual BankAccount BankAcct { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual InEscrowDeposit? CorrectingTransaction { get; set; }
        public virtual Employee CreationEmployee { get; set; } = null!;
        public virtual TypeCdDmt CreditToTypeCd { get; set; } = null!;
        public virtual DepositList? DepositList { get; set; }
        public virtual TypeCdDmt? DepositorTypeCd { get; set; }
        public virtual InEscrowDeposit? DlparentInEscrow { get; set; }
        public virtual Employee? ExcludeEmployee { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual Payment? Payment { get; set; }
        public virtual RealProperty? Property { get; set; }
        public virtual TypeCdDmt RepresentingTypeCd { get; set; } = null!;
        public virtual TypeCdDmt SourceTypeCd { get; set; } = null!;
        public virtual TypeCdDmt StatusTypeCd { get; set; } = null!;
        public virtual TypeCdDmt TransactionTypeCd { get; set; } = null!;
        public virtual DepositAdjustmentComment? DepositAdjustmentComment { get; set; }
        public virtual DepositedReceipt? DepositedReceipt { get; set; }
        public virtual LossRecoveryFee? LossRecoveryFee { get; set; }
        public virtual ICollection<Ibatransaction> Ibatransactions { get; set; }
        public virtual ICollection<InEscrowDeposit> InverseAdjustedTransaction { get; set; }
        public virtual ICollection<InEscrowDeposit> InverseCorrectingTransaction { get; set; }
        public virtual ICollection<InEscrowDeposit> InverseDlparentInEscrow { get; set; }
        public virtual ICollection<OverDraftInEscrowDepositLink> OverDraftInEscrowDepositLinks { get; set; }
        public virtual ICollection<OverDraftInEscrowDepositXref> OverDraftInEscrowDepositXrefs { get; set; }
        public virtual ICollection<ProjectFileSiteFileDepositXref> ProjectFileSiteFileDepositXrefPfinEscrows { get; set; }
        public virtual ICollection<ProjectFileSiteFileDepositXref> ProjectFileSiteFileDepositXrefSfinEscrows { get; set; }
        public virtual ICollection<WireReceipt> WireReceipts { get; set; }
    }
}
