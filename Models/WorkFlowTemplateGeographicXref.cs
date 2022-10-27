using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateGeographicXref
    {
        public int WorkFlowTemplateId { get; set; }
        public int GeoClassTypeCdId { get; set; }
        public int? GeoRegionId { get; set; }
        public int WorkFlowTemplateGeographicXrefId { get; set; }
    }
}
