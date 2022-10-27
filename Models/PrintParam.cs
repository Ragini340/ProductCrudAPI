using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PrintParam
    {
        public long PrintId { get; set; }
        public string? GuidValue { get; set; }
        public string? PrintDetails { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? Isdeleted { get; set; }
        public DateTime? PrintDate { get; set; }
    }
}
