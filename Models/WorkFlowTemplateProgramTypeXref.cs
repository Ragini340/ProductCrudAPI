using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateProgramTypeXref
    {
        public int? WorkFlowTemplateId { get; set; }
        public int? ProgramTypeId { get; set; }
        public int WorkFlowTemplateProgramTypeXrefId { get; set; }

        public virtual ProgramType? ProgramType { get; set; }
        public virtual WorkFlowTemplate? WorkFlowTemplate { get; set; }
    }
}
