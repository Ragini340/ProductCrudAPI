using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Trust32Financial
    {
        public int Trust32FinancialId { get; set; }
        public int RecordClassTypeId { get; set; }
        public int RecordRowId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int ExtractId { get; set; }
        public string LineDefinition { get; set; } = null!;
        public string? DocumentNum { get; set; }
        public decimal? Amount { get; set; }
        public string? FileNum { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? PayorPayeeDescr { get; set; }
        public string? BankName { get; set; }
        public string? BankAcctNum { get; set; }
        public string? Bso { get; set; }
        public string? DetailRecord { get; set; }
    }
}
