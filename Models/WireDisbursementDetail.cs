using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WireDisbursementDetail
    {
        public WireDisbursementDetail()
        {
            Disbursements = new HashSet<Disbursement>();
            IncomingWireDisbursements = new HashSet<IncomingWireDisbursement>();
            WireHistories = new HashSet<WireHistory>();
            WireInstructionValidations = new HashSet<WireInstructionValidation>();
        }

        public int WireDisbursementDetailId { get; set; }
        public string? OriginatorName { get; set; }
        public string? OriginatorInfo { get; set; }
        public string? ReceivingBankAbanum { get; set; }
        public string? ReceivingBankName { get; set; }
        public string? ReceivingBankAddress { get; set; }
        public string? BeneficiaryAccountNum { get; set; }
        public string? BeneficiaryName { get; set; }
        public string? BeneficiaryAddress { get; set; }
        public string? BeneficiaryAdditionalInfo { get; set; }
        public string? BeneficiaryAdviceInfo { get; set; }
        public string? ReceivingBankFicode { get; set; }
        public string? ReceivingBankBranchTransitNumber { get; set; }
        public int? WireTypeCdId { get; set; }
        public DateTime? WireTransmittalDate { get; set; }
        public int? ModifiedByUserId { get; set; }
        public string? TrnfedId { get; set; }
        public string? Estatus { get; set; }
        public int? Istatus { get; set; }
        public string? Comments { get; set; }
        public long? EventLogId { get; set; }
        public string? BeneficiaryNote1 { get; set; }
        public string? BeneficiaryNote2 { get; set; }
        public string? BeneficiaryNote3 { get; set; }
        public string? BeneficiaryNote4 { get; set; }
        public string? IntermediaryBic { get; set; }
        public string? IntermediaryBankName { get; set; }
        public string? IntermediaryBankAddress { get; set; }
        public string? BeneficiaryBic { get; set; }
        public string? BeneficiaryBankName { get; set; }
        public string? BeneficiaryBankAddress { get; set; }
        public byte[]? UpdTs { get; set; }
        public int? ElectronicFileId { get; set; }
        public string? ImgName { get; set; }
        public DateTime? ImgCreatedDate { get; set; }
        public int? ImgTypeCdId { get; set; }
        public int? WireApprovalTypeCdId { get; set; }
        public int? Approval1UserId { get; set; }
        public DateTime? Approval1Date { get; set; }
        public int? Approval2UserId { get; set; }
        public DateTime? Approval2Date { get; set; }
        public int? RejectedUserId { get; set; }
        public DateTime? RejectedDate { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public int? WireInsSourceTypeCdId { get; set; }
        public short? BrokenLinkFlag { get; set; }
        public string? DocExtn { get; set; }
        public int? WireSourceTypeCdId { get; set; }
        public int? WireVerificationInstrCdId { get; set; }
        public int? AccountType { get; set; }
        public int? BeneficiaryAccount { get; set; }

        public virtual TypeCdDmt? WireTypeCd { get; set; }
        public virtual ICollection<Disbursement> Disbursements { get; set; }
        public virtual ICollection<IncomingWireDisbursement> IncomingWireDisbursements { get; set; }
        public virtual ICollection<WireHistory> WireHistories { get; set; }
        public virtual ICollection<WireInstructionValidation> WireInstructionValidations { get; set; }
    }
}
