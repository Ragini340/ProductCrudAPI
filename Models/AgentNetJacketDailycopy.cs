using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AgentNetJacketDailycopy
    {
        public string? StateCode { get; set; }
        public string? StarsunderwriterCode { get; set; }
        public string? UnderwriterName { get; set; }
        public int? JacketId { get; set; }
        public string? JacketDesc { get; set; }
        public int? FaccproductId { get; set; }
        public DateTime? LoadDate { get; set; }
        public int? FaccextendedProductId { get; set; }
        public int AgentNetJacketDailycopyId { get; set; }
    }
}
