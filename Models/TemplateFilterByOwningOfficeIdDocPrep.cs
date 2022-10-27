using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterByOwningOfficeIdDocPrep
    {
        public int TemplateFilterGrpId { get; set; }
        public int? OwningOfficeId { get; set; }
        public int? ServiceTypeId { get; set; }
        public int TemplateFilterByOwningOfficeIdDocPrepId { get; set; }

        public virtual TemplateFilterGrpDocPrep TemplateFilterGrp { get; set; } = null!;
    }
}
