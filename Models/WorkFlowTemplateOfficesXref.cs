using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateOfficesXref
    {
        public int WorkFlowTemplateId { get; set; }
        public int OfficeId { get; set; }
        public int? OfficeGroupId { get; set; }
        public int WorkFlowTemplateOfficesXrefId { get; set; }
    }
}
