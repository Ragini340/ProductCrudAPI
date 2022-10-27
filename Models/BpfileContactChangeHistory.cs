using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BpfileContactChangeHistory
    {
        public int BpfileContactChangeHistoryId { get; set; }
        public int? FileId { get; set; }
        public int? BusinessProgramId { get; set; }
        public int? EventTypeCdId { get; set; }
        public int? ContactId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
