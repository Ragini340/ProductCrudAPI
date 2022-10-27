using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PersonRelationshipChangeHistory
    {
        public int PersonRelationshipChangeHistoryId { get; set; }
        public int? PersonRelationshipId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? StatusId { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual PersonRelationship? PersonRelationship { get; set; }
    }
}
