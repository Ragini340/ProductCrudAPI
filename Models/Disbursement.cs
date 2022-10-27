using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Disbursement
    {
        public Disbursement()
        {
            CheckDisbursements = new HashSet<CheckDisbursement>();
            DisbursementAllocations = new HashSet<DisbursementAllocation>();
            DisbursementTrackInfos = new HashSet<DisbursementTrackInfo>();
            FeeTransferAllocations = new HashSet<FeeTransferAllocation>();
            Ibatransactions = new HashSet<Ibatransaction>();
            InverseAdjustedTransaction = new HashSet<Disbursement>();
            InverseCorrectingTransaction = new HashSet<Disbursement>();
            InverseSuperDisbursement = new HashSet<Disbursement>();
            LossRecoveryFees = new HashSet<LossRecoveryFee>();
            OverDraftDisbursementFbpxrefs = new HashSet<OverDraftDisbursementFbpxref>();
            OverDraftDisbursementXrefs = new HashSet<OverDraftDisbursementXref>();
        }

        public int DisbursementId { get; set; }
        public int ClassTypeId { get; set; }
        public int FileId { get; set; }
        public int? SuperDisbursementId { get; set; }
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
        public int? ExtractId { get; set; }
        public short? ManualCheckFlag { get; set; }
        public DateTime? SplitDate { get; set; }
        public int? SplitByEmployeeId { get; set; }
        public int? AdjustedTransactionId { get; set; }
        public int? AdjustmentReasonTypeCdId { get; set; }
        public int? AdjustmentTypeCdId { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public int? CorrectingTransactionId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[]? UpdTs { get; set; }
        public int? FileFeeDisbursementCauseTypeCdId { get; set; }
        public DateTime? ExportedDate { get; set; }
        public int? GlextractId { get; set; }
        public int? OriginalDisbId { get; set; }
        public string? ManualCheckReason { get; set; }
        public string? PayeeNameOnly { get; set; }
        public string? PayeeAddress { get; set; }
        public string? DefaultVoucherChargeDetails { get; set; }
        public int? AlternateBankActId { get; set; }

        public virtual Disbursement? AdjustedTransaction { get; set; }
        public virtual TypeCdDmt? AdjustmentReasonTypeCd { get; set; }
        public virtual BankAccount? BankAcct { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Disbursement? CorrectingTransaction { get; set; }
        public virtual Trust32Extract? Extract { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
        public virtual TypeCdDmt? FileFeeDisbursementCauseTypeCd { get; set; }
        public virtual FileProcess? FileProcess { get; set; }
        public virtual ExportInfo? Glextract { get; set; }
        public virtual Employee? HeldByEmployee { get; set; }
        public virtual Employee? IssuedByEmployee { get; set; }
        public virtual Employee? ReleasedByEmployee { get; set; }
        public virtual TypeCdDmt? SourceTypeCd { get; set; }
        public virtual Employee? SplitByEmployee { get; set; }
        public virtual TypeCdDmt? StatusTypeCd { get; set; }
        public virtual Disbursement? SuperDisbursement { get; set; }
        public virtual TypeCdDmt? TransactionTypeCd { get; set; }
        public virtual WireDisbursementDetail? WireDisbursementDetail { get; set; }
        public virtual OverdraftDisbursement? OverdraftDisbursement { get; set; }
        public virtual PaidDisbursement? PaidDisbursement { get; set; }
        public virtual ICollection<CheckDisbursement> CheckDisbursements { get; set; }
        public virtual ICollection<DisbursementAllocation> DisbursementAllocations { get; set; }
        public virtual ICollection<DisbursementTrackInfo> DisbursementTrackInfos { get; set; }
        public virtual ICollection<FeeTransferAllocation> FeeTransferAllocations { get; set; }
        public virtual ICollection<Ibatransaction> Ibatransactions { get; set; }
        public virtual ICollection<Disbursement> InverseAdjustedTransaction { get; set; }
        public virtual ICollection<Disbursement> InverseCorrectingTransaction { get; set; }
        public virtual ICollection<Disbursement> InverseSuperDisbursement { get; set; }
        public virtual ICollection<LossRecoveryFee> LossRecoveryFees { get; set; }
        public virtual ICollection<OverDraftDisbursementFbpxref> OverDraftDisbursementFbpxrefs { get; set; }
        public virtual ICollection<OverDraftDisbursementXref> OverDraftDisbursementXrefs { get; set; }
    }
}
