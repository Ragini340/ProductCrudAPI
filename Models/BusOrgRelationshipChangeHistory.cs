using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgRelationshipChangeHistory
    {
        public int BusOrgRelationshipChangeHistoryId { get; set; }
        public int? BusOrgRelationshipId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? StatusId { get; set; }

        public virtual BusOrgRelationship? BusOrgRelationship { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
