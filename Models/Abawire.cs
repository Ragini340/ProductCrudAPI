using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Abawire
    {
        public int AbawireId { get; set; }
        public int Abaid { get; set; }
        public string Aba { get; set; } = null!;
        public string TelegraphicName { get; set; } = null!;
        public string Customer { get; set; } = null!;
        public string State { get; set; } = null!;
        public string City { get; set; } = null!;
        public string FundTransfer { get; set; } = null!;
        public string SettlementOnly { get; set; } = null!;
        public string Book { get; set; } = null!;
        public DateTime? LastRevision { get; set; }
        public string ChangedBy { get; set; } = null!;
        public string? OfficeCode { get; set; }
        public string? Frbnumber { get; set; }
        public string? RecordTypeCode { get; set; }
        public string? NewRoutingNumber { get; set; }
        public string? DataViewCode { get; set; }
        public int? AbaidentifierTypeCdid { get; set; }
    }
}
