using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InvoiceExtractCharMapping
    {
        public string? UnicodeChar { get; set; }
        public string? AsciiChar { get; set; }
        public int InvoiceExtractCharMappingId { get; set; }
    }
}
