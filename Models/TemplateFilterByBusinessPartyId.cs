using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterByBusinessPartyId
    {
        public int TemplateFilterGrpId { get; set; }
        public int? BusOrgId { get; set; }
        public int? EntityType { get; set; }
        public int TemplateFilterByBusinessPartyIdid { get; set; }
    }
}
