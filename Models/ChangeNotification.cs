using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ChangeNotification
    {
        public ChangeNotification()
        {
            Applications = new HashSet<Application>();
        }

        public int ChangeNotificationId { get; set; }
        public string? Descr { get; set; }
        public string? ObjectCd { get; set; }
        public int? SuperChangeNotificationId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Comments { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}
