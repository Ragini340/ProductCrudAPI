using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FftbusOrgXref
    {
        public int FeeFilterTemplateId { get; set; }
        public int? BusOrgId { get; set; }
        public int FftbusOrgXrefId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual FeeFilterTemplate FeeFilterTemplate { get; set; } = null!;
    }
}
