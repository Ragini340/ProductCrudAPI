using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SettlementStatementHeaderDetail
    {
        public int Ssid { get; set; }
        public int? FileId { get; set; }
        public int? RoleTypeCdId { get; set; }
        public int? BuySelLenPropId { get; set; }
        public string? ModifiedName { get; set; }
        public bool? IsNameModified { get; set; }
        public string? ModifiedAddress { get; set; }
        public bool? IsAddressModified { get; set; }
        public bool? DisplayName { get; set; }
        public bool? DisplayAddress { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public bool? DisplayVestingInterest { get; set; }

        public virtual ServiceFile? File { get; set; }
    }
}
