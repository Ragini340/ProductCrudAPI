using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFeeStatusHistory
    {
        public int ServiceFeeStatusHistoryId { get; set; }
        public int ServiceFeeId { get; set; }
        public int? DocumentNum { get; set; }
        public int? ServiceFeeExtractId { get; set; }
        public int StatusCd { get; set; }
        public int StatusChangedUser { get; set; }
        public DateTime StatusChangedDate { get; set; }
        public string? StatusChangedReason { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
