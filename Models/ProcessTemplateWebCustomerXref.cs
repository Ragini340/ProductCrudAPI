using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProcessTemplateWebCustomerXref
    {
        public int? WorkFlowTemplateId { get; set; }
        public int? WebCustomerTypeCdId { get; set; }
        public int ProcessTemplateWebCustomerXrefId { get; set; }

        public virtual TypeCdDmt? WebCustomerTypeCd { get; set; }
        public virtual WorkFlowTemplate? WorkFlowTemplate { get; set; }
    }
}
