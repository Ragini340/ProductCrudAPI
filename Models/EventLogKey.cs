using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EventLogKey
    {
        public EventLogKey()
        {
            EventLogOes = new HashSet<EventLogOe>();
            RecordedDocEventLogs = new HashSet<RecordedDocEventLog>();
        }

        public long EventLogId { get; set; }
        public byte EventGrp { get; set; }

        public virtual ClosingDisclosureEventLog? ClosingDisclosureEventLog { get; set; }
        public virtual GabrefreshEventLog? GabrefreshEventLog { get; set; }
        public virtual IntegrationServicesEventLog? IntegrationServicesEventLog { get; set; }
        public virtual RecordingEventLog? RecordingEventLog { get; set; }
        public virtual SigningEventLog? SigningEventLog { get; set; }
        public virtual ICollection<EventLogOe> EventLogOes { get; set; }
        public virtual ICollection<RecordedDocEventLog> RecordedDocEventLogs { get; set; }
    }
}
