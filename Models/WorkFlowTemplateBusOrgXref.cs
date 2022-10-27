using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateBusOrgXref
    {
        public int WorkFlowTemplateId { get; set; }
        public int? BusOrgId { get; set; }
        public int WorkFlowTemplateBusOrgXrefId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual WorkFlowTemplate WorkFlowTemplate { get; set; } = null!;
    }
}
