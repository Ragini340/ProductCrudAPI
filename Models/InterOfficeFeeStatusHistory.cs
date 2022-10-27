using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InterOfficeFeeStatusHistory
    {
        public int InterOfficeFeeStatusHistoryId { get; set; }
        public int InterOfficeFeeId { get; set; }
        public int? DocumentNum { get; set; }
        public int? InterOfficeFeeExtractId { get; set; }
        public int StatusCd { get; set; }
        public int StatusChangedUser { get; set; }
        public DateTime StatusChangedDate { get; set; }
        public string? StatusChangedReason { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual InterOfficeFee InterOfficeFee { get; set; } = null!;
    }
}
