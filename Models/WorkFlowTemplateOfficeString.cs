using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateOfficeString
    {
        public int? WorkFlowTemplateId { get; set; }
        public string? OfficeNames { get; set; }
        public string? OfficeIds { get; set; }
        public int WorkFlowTemplateOfficeStringsId { get; set; }
    }
}
