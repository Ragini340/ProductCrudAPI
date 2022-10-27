using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EcheckDetail
    {
        public int EcheckDetailId { get; set; }
        public int FileId { get; set; }
        public string FileNum { get; set; } = null!;
        public string EcheckRefId { get; set; } = null!;
        public string EncryptionKey { get; set; } = null!;
        public int InterfacePartnerTypeCdId { get; set; }
        public long DeliveryEventLogId { get; set; }
        public string PayeeName { get; set; } = null!;
        public decimal CheckAmount { get; set; }
        public int RequestedUserId { get; set; }
        public byte EcheckStatus { get; set; }
        public byte NotificationFlag { get; set; }
        public string CheckNumber { get; set; } = null!;
        public int DisbursementId { get; set; }
        public string? ImagePath { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? PayeeEmailId { get; set; }

        public virtual DeliveryEventLog DeliveryEventLog { get; set; } = null!;
        public virtual Employee RequestedUser { get; set; } = null!;
    }
}
