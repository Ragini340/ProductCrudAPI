using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BpfileBusOrgChangeHistory
    {
        public int BpfileBusOrgChangeHistoryId { get; set; }
        public int? FileId { get; set; }
        public int? BusinessProgramId { get; set; }
        public int? EventTypeCdId { get; set; }
        public int? BusOrgId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
