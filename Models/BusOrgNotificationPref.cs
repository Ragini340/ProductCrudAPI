using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgNotificationPref
    {
        public BusOrgNotificationPref()
        {
            NotificationTemplates = new HashSet<NotificationTemplate>();
        }

        public int BusOrgPrefId { get; set; }
        public int BusOrgId { get; set; }
        public int ElectronicAddrId { get; set; }
        public int NotificationType { get; set; }

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual ElectronicAddr ElectronicAddr { get; set; } = null!;
        public virtual ICollection<NotificationTemplate> NotificationTemplates { get; set; }
    }
}
