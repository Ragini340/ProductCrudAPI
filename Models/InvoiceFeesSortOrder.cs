using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InvoiceFeesSortOrder
    {
        public int InvoiceId { get; set; }
        public string? SortOrderXml { get; set; }
        public short? IsSequenced { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
    }
}
