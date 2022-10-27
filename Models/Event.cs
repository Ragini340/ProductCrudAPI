using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Event
    {
        public Event()
        {
            AccountingPrivacyEventLogs = new HashSet<AccountingPrivacyEventLog>();
            ClosingDisclosureEventLogs = new HashSet<ClosingDisclosureEventLog>();
            DeliveryEventLogs = new HashSet<DeliveryEventLog>();
            EventLogOes = new HashSet<EventLogOe>();
            GabrefreshEventLogs = new HashSet<GabrefreshEventLog>();
            IntegrationServicesEventLogs = new HashSet<IntegrationServicesEventLog>();
            InverseSuperEvent = new HashSet<Event>();
            RecordedDocEventLogs = new HashSet<RecordedDocEventLog>();
            RecordingEventLogs = new HashSet<RecordingEventLog>();
            SigningEventLogs = new HashSet<SigningEventLog>();
        }

        public int EventId { get; set; }
        public int ClassTypeId { get; set; }
        public int? SuperEventId { get; set; }
        public string Name { get; set; } = null!;
        public short? SeqNum { get; set; }
        public int EventStatusCd { get; set; }
        public short InboxFlag { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationUser { get; set; } = null!;
        public virtual Employee? StatusChgUser { get; set; }
        public virtual Event? SuperEvent { get; set; }
        public virtual ICollection<AccountingPrivacyEventLog> AccountingPrivacyEventLogs { get; set; }
        public virtual ICollection<ClosingDisclosureEventLog> ClosingDisclosureEventLogs { get; set; }
        public virtual ICollection<DeliveryEventLog> DeliveryEventLogs { get; set; }
        public virtual ICollection<EventLogOe> EventLogOes { get; set; }
        public virtual ICollection<GabrefreshEventLog> GabrefreshEventLogs { get; set; }
        public virtual ICollection<IntegrationServicesEventLog> IntegrationServicesEventLogs { get; set; }
        public virtual ICollection<Event> InverseSuperEvent { get; set; }
        public virtual ICollection<RecordedDocEventLog> RecordedDocEventLogs { get; set; }
        public virtual ICollection<RecordingEventLog> RecordingEventLogs { get; set; }
        public virtual ICollection<SigningEventLog> SigningEventLogs { get; set; }
    }
}
