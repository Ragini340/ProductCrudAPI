using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PrincipalNotification
    {
        public int PrincipalNotificationId { get; set; }
        public int ElectronicAddrId { get; set; }
        public bool? NotificationFlag { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ElectronicAddr ElectronicAddr { get; set; } = null!;
    }
}
