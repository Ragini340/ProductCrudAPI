using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgContactNotificationPref
    {
        public BusOrgContactNotificationPref()
        {
            NotificationTemplates = new HashSet<NotificationTemplate>();
        }

        public int BusOrgContactPrefId { get; set; }
        public int ContactId { get; set; }
        public int ElectronicAddrId { get; set; }
        public int NotificationType { get; set; }

        public virtual BusOrgContact Contact { get; set; } = null!;
        public virtual ElectronicAddr ElectronicAddr { get; set; } = null!;
        public virtual ICollection<NotificationTemplate> NotificationTemplates { get; set; }
    }
}
