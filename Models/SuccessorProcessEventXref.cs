using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SuccessorProcessEventXref
    {
        public int ProcessTypeId { get; set; }
        public int WorkflowTemplateId { get; set; }
        public int? SuccessorStatusCd { get; set; }
        public int SuccessorProcessEventXrefId { get; set; }
    }
}
