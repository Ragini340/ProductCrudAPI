using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CorpEbusInterfaceFormatXref
    {
        public int CorporateBusOrgId { get; set; }
        public int EbusinessTypeCdId { get; set; }
        public int EbusFormatTypeCdId { get; set; }
        public decimal? FeeAmount { get; set; }
        public byte? FeeCycleDays { get; set; }

        public virtual CorporateBusOrg CorporateBusOrg { get; set; } = null!;
        public virtual TypeCdDmt EbusinessTypeCd { get; set; } = null!;
    }
}
