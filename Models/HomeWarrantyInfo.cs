using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class HomeWarrantyInfo
    {
        public int FileProcessId { get; set; }
        public int? PaidByTypeCdId { get; set; }
        public decimal? ChargeAmtNotToExceed { get; set; }
        public decimal? PerDiemAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public short? FromDateInclusiveFlag { get; set; }
        public DateTime? ToDate { get; set; }
        public short? ToDateInclusiveFlag { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual TypeCdDmt? PaidByTypeCd { get; set; }
    }
}
