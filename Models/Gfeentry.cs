using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Gfeentry
    {
        public int GfeId { get; set; }
        public int? ClassTypeId { get; set; }
        public int? FileId { get; set; }
        public decimal? OriginationChargeAmount { get; set; }
        public short PointFlag { get; set; }
        public decimal? Points { get; set; }
        public decimal? LenderTitleInsuranceAmount { get; set; }
        public decimal? OwnerTitleInsuranceAmount { get; set; }
        public decimal? RecordingChargeAmount { get; set; }
        public decimal? TransferTaxes { get; set; }
        public decimal? InitDepositAmount { get; set; }
        public decimal? DailyIntchargeAmount { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? InterestFlag { get; set; }
        public short? OriginationFlag { get; set; }
        public decimal? Gfe8tolCureAmt { get; set; }
        public int? Gfe8tolCurePaymntMtdId { get; set; }
        public string? Gfe8desForTolCure { get; set; }
        public decimal? RecordingLoanEstUnrounded { get; set; }
        public decimal? RecordingLoanEstRounded { get; set; }
        public decimal? TranTaxLoanEstUnrounded { get; set; }
        public decimal? TranTaxLoanEstRounded { get; set; }
        public int? DisplaySalesTaxTypeCdId { get; set; }

        public virtual ServiceFile? File { get; set; }
    }
}
