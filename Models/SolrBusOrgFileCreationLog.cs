using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SolrBusOrgFileCreationLog
    {
        public int Id { get; set; }
        public int? RegionId { get; set; }
        public int? StartId { get; set; }
        public int? EndId { get; set; }
        public string? XmlfileName { get; set; }
        public byte? Status { get; set; }
    }
}
