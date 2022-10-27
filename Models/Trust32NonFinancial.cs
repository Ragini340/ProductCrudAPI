using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Trust32NonFinancial
    {
        public int Trust32NonFinancialId { get; set; }
        public int RecordClassTypeId { get; set; }
        public int RecordRowId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int ExtractId { get; set; }
        public string? FileNum { get; set; }
        public string? Buyer { get; set; }
        public string? Seller { get; set; }
        public string? PropertyAddress { get; set; }
        public string? Officer { get; set; }
        public DateTime? OpenDate { get; set; }
        public string? Status { get; set; }
        public string? DetailRecord { get; set; }
    }
}
