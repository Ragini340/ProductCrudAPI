using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgContactRelationshipChangeHistory
    {
        public int BusOrgContactRelationshipChangeHistoryId { get; set; }
        public int? BusOrgContactRelationshipId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? StatusId { get; set; }

        public virtual BusOrgContactRelationship? BusOrgContactRelationship { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
