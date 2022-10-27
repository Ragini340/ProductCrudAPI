using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileFeePaymentDetail
    {
        public int ServiceFileFeePaymentDetailId { get; set; }
        public int ServiceFileFeeId { get; set; }
        public int ChargePaidByTypeCdId { get; set; }
        public decimal PaidChargeAmt { get; set; }
        public decimal? SalesTaxAmt { get; set; }
        public int PaymentMethodTypeCdId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual TypeCdDmt ChargePaidByTypeCd { get; set; } = null!;
        public virtual TypeCdDmt PaymentMethodTypeCd { get; set; } = null!;
        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
    }
}
