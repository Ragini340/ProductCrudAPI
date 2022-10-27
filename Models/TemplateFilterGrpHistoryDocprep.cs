using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterGrpHistoryDocprep
    {
        public int TemplateFilterGrpHistoryId { get; set; }
        public int TemplateId { get; set; }
        public string? TemplateFilterDetails { get; set; }
    }
}
