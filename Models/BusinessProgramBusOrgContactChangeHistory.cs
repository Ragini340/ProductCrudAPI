using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessProgramBusOrgContactChangeHistory
    {
        public int BphistoryId { get; set; }
        public int ContactId { get; set; }
        public int EventTypeCdId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string Notes { get; set; } = null!;

        public virtual BusOrgContact Contact { get; set; } = null!;
        public virtual Employee CreatedByNavigation { get; set; } = null!;
        public virtual TypeCdDmt EventTypeCd { get; set; } = null!;
    }
}
