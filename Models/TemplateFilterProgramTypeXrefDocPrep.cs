using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterProgramTypeXrefDocPrep
    {
        public int? TemplateFilterGrpId { get; set; }
        public int? ProgramTypeId { get; set; }
        public int TemplateFilterProgramTypeXrefDocPrepId { get; set; }

        public virtual ProgramType? ProgramType { get; set; }
        public virtual TemplateFilterGrpDocPrep? TemplateFilterGrp { get; set; }
    }
}
