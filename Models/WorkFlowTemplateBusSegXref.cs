using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateBusSegXref
    {
        public int WorkFlowTemplateId { get; set; }
        public int? BusSegTypeCdId { get; set; }
        public int WorkFlowTemplateBusSegXrefId { get; set; }
    }
}
