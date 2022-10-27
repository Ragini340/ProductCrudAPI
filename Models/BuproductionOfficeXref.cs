using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BuproductionOfficeXref
    {
        public int BusinessUnitId { get; set; }
        public int ServiceTypeCdId { get; set; }
        public int ProductionOfficeId { get; set; }
        public int? SeqNum { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual BusinessUnit ProductionOffice { get; set; } = null!;
        public virtual TypeCdDmt ServiceTypeCd { get; set; } = null!;
    }
}
