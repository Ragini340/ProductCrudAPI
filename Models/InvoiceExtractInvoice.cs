using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InvoiceExtractInvoice
    {
        public int? FileId { get; set; }
        public int? InvoiceId { get; set; }
        public int? InvoiceStatusCdId { get; set; }
        public int? BusinessUnitId { get; set; }
    }
}
