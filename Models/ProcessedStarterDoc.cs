using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProcessedStarterDoc
    {
        public int ProcessedStarterDocId { get; set; }
        public int? FileId { get; set; }
        public int? DocId { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string? PdffileName { get; set; }
        public string? Message { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? FileNum { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? OwningOfficeId { get; set; }
        public string? OwningOfficeObjectCd { get; set; }
        public string? OwningOfficeCountyName { get; set; }
        public decimal? LoanLiabilityAmount { get; set; }
        public string? TaxNums { get; set; }
        public string? PropertyCountyName { get; set; }
        public string? PropertyStateCd { get; set; }
    }
}
