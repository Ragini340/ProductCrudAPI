using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EmployeeNotificationPref
    {
        public EmployeeNotificationPref()
        {
            NotificationTemplates = new HashSet<NotificationTemplate>();
        }

        public int EmployeePrefId { get; set; }
        public int EmployeeId { get; set; }
        public int ElectronicAddrId { get; set; }
        public int NotificationType { get; set; }

        public virtual ElectronicAddr ElectronicAddr { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual ICollection<NotificationTemplate> NotificationTemplates { get; set; }
    }
}
