using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadInvoice
    {
        public int InvoiceId { get; set; }
        public int? FileId { get; set; }
        public string? InvoiceClassTypeDescr { get; set; }
        public int OrderId { get; set; }
        public string? BillToEntityRoleTypeCdDescr { get; set; }
        public long? InvoiceNum { get; set; }
        public DateTime? InvoiceStatusDate { get; set; }
        public int? InvoicedByEmployeeId { get; set; }
        public string? InvoiceStatus { get; set; }
        public DateTime? ExportRequestDate { get; set; }
        public string? Comments { get; set; }
        public DateTime? ExportStartDate { get; set; }
        public DateTime? ExportEndDate { get; set; }
    }
}
