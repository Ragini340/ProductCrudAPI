using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TmpSourceApplQueueName
    {
        public int? RegionId { get; set; }
        public int OwnerOfficeId { get; set; }
        public int FileId { get; set; }
        public string FileNum { get; set; } = null!;
        public int FileStatus { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int OrderId { get; set; }
        public int ClassTypeId { get; set; }
        public int? StatusCd { get; set; }
        public int SourceApplId { get; set; }
        public string? SourceApplQueueName { get; set; }
        public string? RefNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? OrderOriginatorId { get; set; }
        public string? ReverseEntity { get; set; }
        public string? RelatedTransaction { get; set; }
        public int? SecondSourceApplId { get; set; }
        public string? SecondSourceApplQueueName { get; set; }
        public int? SecondOrderOriginatorId { get; set; }
        public string? FirstSourceBusinessPartyName { get; set; }
        public string? SecondSourceBusinessPartyName { get; set; }
    }
}
