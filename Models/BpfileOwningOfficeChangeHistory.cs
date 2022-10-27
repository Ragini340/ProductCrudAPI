using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BpfileOwningOfficeChangeHistory
    {
        public int BpfileOwngOfficeChangeHistoryId { get; set; }
        public int? FileId { get; set; }
        public int? BusinessProgramId { get; set; }
        public int? EventTypeCdId { get; set; }
        public int? OwningOfficeId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
