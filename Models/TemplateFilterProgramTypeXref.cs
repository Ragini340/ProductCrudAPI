using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterProgramTypeXref
    {
        public int? TemplateFilterGrpId { get; set; }
        public int? ProgramTypeId { get; set; }
        public int TemplateFilterProgramTypeXrefId { get; set; }

        public virtual ProgramType? ProgramType { get; set; }
        public virtual TemplateFilterGrp? TemplateFilterGrp { get; set; }
    }
}
