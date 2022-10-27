using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Trust32ExtractParameter
    {
        public int BusinessUnitId { get; set; }
        public DateTime ExtractCutOffDateTime { get; set; }
        public int? StatusCd { get; set; }
        public string? ExtractType { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
