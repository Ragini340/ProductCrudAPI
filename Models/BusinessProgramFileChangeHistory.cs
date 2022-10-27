using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessProgramFileChangeHistory
    {
        public int BpfileChangeHistoryId { get; set; }
        public int? FileId { get; set; }
        public int? BusinessProgramId { get; set; }
        public int? EventTypeCdId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UserId { get; set; }
        public int? AssociatedClassTypeId { get; set; }

        public virtual ClassType? AssociatedClassType { get; set; }
    }
}
