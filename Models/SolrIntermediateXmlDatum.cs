using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SolrIntermediateXmlDatum
    {
        public int Id { get; set; }
        public int? StepId { get; set; }
        public int? RegionId { get; set; }
        public string? XmlData { get; set; }
    }
}
