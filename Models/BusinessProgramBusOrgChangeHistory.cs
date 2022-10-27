using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessProgramBusOrgChangeHistory
    {
        public int BphistoryId { get; set; }
        public int BusOrgId { get; set; }
        public int EventTypeCdId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string Notes { get; set; } = null!;

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual Employee CreatedByNavigation { get; set; } = null!;
        public virtual TypeCdDmt EventTypeCd { get; set; } = null!;
    }
}
