using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ToleranceCure
    {
        public int ToleranceCureId { get; set; }
        public int? FileId { get; set; }
        public int? ClassTypeId { get; set; }
        public int? ToleranceTypeCdId { get; set; }
        public int? CuredByEntityTypeCdId { get; set; }
        public string? CurerName { get; set; }
        public decimal? CuredAmount { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType? ClassType { get; set; }
        public virtual ServiceFile? File { get; set; }
    }
}
