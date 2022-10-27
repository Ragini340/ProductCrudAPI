using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VWwireDisbursementDetailIngrian
    {
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
        public string? BeneficiaryAccountNum2 { get; set; }
    }
}
