using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Fast1099sHeader
    {
        public int Fast1099sHeaderId { get; set; }
        public int? FileId { get; set; }
        public int? PropertydescrTypeCdId { get; set; }
        public string? PropertyDescr { get; set; }
        public short PropConsideration { get; set; }
        public byte[]? UpdTs { get; set; }
        public short? SalePriceFlag { get; set; }
        public short? RetaxFlag { get; set; }

        public virtual ServiceFile? File { get; set; }
        public virtual TypeCdDmt? PropertydescrTypeCd { get; set; }
    }
}
