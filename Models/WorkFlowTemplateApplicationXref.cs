using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateApplicationXref
    {
        public int WorkFlowtemplateId { get; set; }
        public int? ApplicationId { get; set; }
        public int? SourceTypeCdId { get; set; }
        public int WorkFlowTemplateApplicationXrefId { get; set; }

        public virtual Application? Application { get; set; }
        public virtual WorkFlowTemplate WorkFlowtemplate { get; set; } = null!;
    }
}
