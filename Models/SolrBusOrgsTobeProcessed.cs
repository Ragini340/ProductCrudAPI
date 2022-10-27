using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SolrBusOrgsTobeProcessed
    {
        public int Id { get; set; }
        public int? RegionId { get; set; }
        public int? BusOrgId { get; set; }
    }
}
