using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AssociationInfo
    {
        public int FileProcessId { get; set; }
        public int? AmtDuePeriodTypeCdId { get; set; }
        public decimal? AmtDue { get; set; }
        public int? MgmtCoFileBusinessPartyId { get; set; }

        public virtual TypeCdDmt? AmtDuePeriodTypeCd { get; set; }
        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual FileBusinessParty? MgmtCoFileBusinessParty { get; set; }
    }
}
