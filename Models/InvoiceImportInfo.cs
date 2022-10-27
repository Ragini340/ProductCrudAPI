using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InvoiceImportInfo
    {
        public int ImportInfoId { get; set; }
        public DateTime ImportStartDate { get; set; }
        public DateTime? ImportEndDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusCd { get; set; }
        public string? ImportXml { get; set; }
        public byte[] Updts { get; set; } = null!;
    }
}
