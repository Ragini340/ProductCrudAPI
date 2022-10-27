using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RebrokerInfo
    {
        public int FileProcessId { get; set; }
        public int? ReagentId { get; set; }
        public decimal? CommissionPercent { get; set; }
        public decimal? CreditToBuyerAmt { get; set; }
        public decimal? CreditToSellerAmt { get; set; }
        public decimal? CreditToSellerBrokerAmt { get; set; }
        public decimal? CreditToBuyerBrokerAmt { get; set; }
        public decimal? CommissionAmount { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual FileBusinessParty? Reagent { get; set; }
    }
}
