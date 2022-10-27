using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NotificationTemplate
    {
        public NotificationTemplate()
        {
            NotificationDocumentTemplates = new HashSet<NotificationDocumentTemplate>();
            NotificationTemplateFbproleXrefs = new HashSet<NotificationTemplateFbproleXref>();
            NotificationTemplateSenderInfoXrefs = new HashSet<NotificationTemplateSenderInfoXref>();
            NotificationTemplateStaticEmailXrefs = new HashSet<NotificationTemplateStaticEmailXref>();
            TaskTemplates = new HashSet<TaskTemplate>();
        }

        public int NotificationTemplateId { get; set; }
        public byte TaskStatus { get; set; }
        public byte DeliveryMethod { get; set; }
        public byte? TaskGabflag { get; set; }
        public byte? StatusCd { get; set; }
        public int? MessageTemplateId { get; set; }
        public string? SubjectLine { get; set; }
        public string? SubjectName { get; set; }
        public int? SuperNotificationTemplateId { get; set; }
        public int? AttachmentFormat { get; set; }
        public int? AttachmentType { get; set; }
        public string? PackageName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public DateTime? LastActivatedDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public byte? EditedDeletedFlag { get; set; }
        public int? BusOrgPrefId { get; set; }
        public int? BusOrgContactPrefId { get; set; }
        public int? EmployeePrefId { get; set; }
        public string? DocSelectionCriteria { get; set; }
        public string? DocParseStr { get; set; }
        public string? DocSelList { get; set; }
        public int? RegionId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public byte? IsProcessedToBpm { get; set; }
        public int? PersonPrefId { get; set; }
        public string? MessageTemplateObjectCd { get; set; }

        public virtual BusOrgContactNotificationPref? BusOrgContactPref { get; set; }
        public virtual BusOrgNotificationPref? BusOrgPref { get; set; }
        public virtual Employee? CreatedUser { get; set; }
        public virtual EmployeeNotificationPref? EmployeePref { get; set; }
        public virtual PersonNotificationPref? PersonPref { get; set; }
        public virtual Employee? StatusChgUser { get; set; }
        public virtual ICollection<NotificationDocumentTemplate> NotificationDocumentTemplates { get; set; }
        public virtual ICollection<NotificationTemplateFbproleXref> NotificationTemplateFbproleXrefs { get; set; }
        public virtual ICollection<NotificationTemplateSenderInfoXref> NotificationTemplateSenderInfoXrefs { get; set; }
        public virtual ICollection<NotificationTemplateStaticEmailXref> NotificationTemplateStaticEmailXrefs { get; set; }

        public virtual ICollection<TaskTemplate> TaskTemplates { get; set; }
    }
}
