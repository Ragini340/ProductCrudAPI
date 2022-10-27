using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwCpCreateMemoRecord
    {
        public long SmstranslogId { get; set; }
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? BusinessUnitId { get; set; }
        public string FileNum { get; set; } = null!;
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public DateTime? ActualReleaseDate { get; set; }
        public DateTime? HoldDate { get; set; }
        public short BaseFileFlag { get; set; }
        public int? Fpcount { get; set; }
    }
}
