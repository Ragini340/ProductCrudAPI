using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ExchangeTdsinfo
    {
        public ExchangeTdsinfo()
        {
            Properties = new HashSet<RealProperty>();
            TitleEscrowInfos = new HashSet<TitleEscrowInfo>();
        }

        public int ExchangeTdsinfoId { get; set; }
        public string? AssignedEscrowNum { get; set; }
        public decimal? SalesPriceAmt { get; set; }
        public int? EscrowOfficerFbpid { get; set; }
        public int? TaxPayerAgentFbpid { get; set; }
        public int? BuyerSellerAgentFbpid { get; set; }
        public int? EstimatedDaysToClose { get; set; }
        public DateTime? EstimatedSettlementDate { get; set; }
        public DateTime? Coedate { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? ContractAcceptanceDate { get; set; }
        public bool? IsPrelimReceived { get; set; }
        public bool? IsAgreementReceived { get; set; }
        public bool? IsActualCoe { get; set; }
        public string? ActionNumber { get; set; }
        public int? ActionTypeCdId { get; set; }
        public decimal? InterestinProperty { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public long? BuyerFullConsolidateVestId { get; set; }
        public long? SellerShortConsolidateVestId { get; set; }
        public string? FastSearchType { get; set; }
        public short? FsbuyerFullVestFlag { get; set; }
        public long? SellerFullConsolidateVestId { get; set; }
        public long? BuyerShortConsolidateVestId { get; set; }
        public short? IsCancelledFlag { get; set; }

        public virtual ICollection<RealProperty> Properties { get; set; }
        public virtual ICollection<TitleEscrowInfo> TitleEscrowInfos { get; set; }
    }
}
