using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IncomingWireDeposit
    {
        public int IncomingWireDepositId { get; set; }
        public int IncomingWireDetailId { get; set; }
        public bool? DepositStatus { get; set; }
        public bool? DeliveryStatus { get; set; }
        public int? AchsourceTypeId { get; set; }
        public bool? ErrorStatus { get; set; }
        public string? ErrorInfo { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? TargetFileId { get; set; }

        public virtual TypeCdDmt? AchsourceType { get; set; }
        public virtual IncomingWireDetail IncomingWireDetail { get; set; } = null!;
    }
}
