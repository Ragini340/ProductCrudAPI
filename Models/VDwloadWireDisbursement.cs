using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadWireDisbursement
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
    }
}
