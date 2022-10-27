using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TitleEscrowInfoSalesPriceXref
    {
        public int TitleEscrowInfoSalesPriceXrefId { get; set; }
        public int TitleEscrowInfoId { get; set; }
        public int SalePriceTypeCdId { get; set; }
        public string? Descr { get; set; }
        public decimal? Amount { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual TypeCdDmt SalePriceTypeCd { get; set; } = null!;
        public virtual TitleEscrowInfo TitleEscrowInfo { get; set; } = null!;
    }
}
