using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterByBusinessPartyIdDocPrep
    {
        public int TemplateFilterGrpId { get; set; }
        public int? BusOrgId { get; set; }
        public int? EntityType { get; set; }
        public int TemplateFilterByBusinessPartyIdDocPrepId { get; set; }

        public virtual TemplateFilterGrpDocPrep TemplateFilterGrp { get; set; } = null!;
    }
}
