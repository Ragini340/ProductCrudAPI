using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PersonNotificationPref
    {
        public PersonNotificationPref()
        {
            NotificationTemplates = new HashSet<NotificationTemplate>();
        }

        public int PersonPrefId { get; set; }
        public int PersonId { get; set; }
        public int ElectronicAddrId { get; set; }
        public int NotificationType { get; set; }

        public virtual ElectronicAddr ElectronicAddr { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
        public virtual ICollection<NotificationTemplate> NotificationTemplates { get; set; }
    }
}
