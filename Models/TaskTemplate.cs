using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplate
    {
        public TaskTemplate()
        {
            InverseSuperTaskTemplate = new HashSet<TaskTemplate>();
            TaskTemplateCustomerXrefs = new HashSet<TaskTemplateCustomerXref>();
            TaskTemplatePackageDetails = new HashSet<TaskTemplatePackageDetail>();
            TaskTemplateSuccessorStatuses = new HashSet<TaskTemplateSuccessorStatus>();
            TaskTemplateTriggerEventRuleXrefs = new HashSet<TaskTemplateTriggerEventRuleXref>();
            BusinessUnits = new HashSet<BusinessUnit>();
            NotificationTemplates = new HashSet<NotificationTemplate>();
            WorkGroups = new HashSet<WorkGroup>();
        }

        public int TaskTemplateId { get; set; }
        public int? WorkFlowTemplateId { get; set; }
        public int TaskCategoryId { get; set; }
        public string? Name { get; set; }
        public short? WarnDays { get; set; }
        public short? Duedays { get; set; }
        public int DueDateTypeCdId { get; set; }
        public short? SeqNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public byte? IsPrivate { get; set; }
        public int? WarnHours { get; set; }
        public int? WarnMinutes { get; set; }
        public int? DueHours { get; set; }
        public int? DueMinutes { get; set; }
        public int? TaskEventId { get; set; }
        public int? FileEventId { get; set; }
        public int? FileEventStatusCd { get; set; }
        public int? SuccessorStatusCd { get; set; }
        public int? SuccessorTrackNum { get; set; }
        public int? SuperTaskTemplateId { get; set; }
        public byte? StatusCd { get; set; }
        public int? TaskEventRuleId { get; set; }
        public int? WorkGroupId { get; set; }
        public int? ProductionCenterId { get; set; }
        public int? OfficeRoleTypeCdId { get; set; }
        public int? FileEventRuleId { get; set; }
        public int? TaskEventStatusCd { get; set; }
        public byte? Ucflag { get; set; }
        public string? FriendlyName { get; set; }
        public int TaskEventSeqNum { get; set; }
        public byte CommentCodeRequired { get; set; }
        public byte IsModifyDueDate { get; set; }
        public int ExpirationTypeCdId { get; set; }
        public short? ExpirationDays { get; set; }
        public byte? PreventWaive { get; set; }

        public virtual TypeCdDmt DueDateTypeCd { get; set; } = null!;
        public virtual TaskTemplate? SuperTaskTemplate { get; set; }
        public virtual TaskCategory TaskCategory { get; set; } = null!;
        public virtual TriggerEventRule? TaskEventRule { get; set; }
        public virtual WorkFlowTemplate? WorkFlowTemplate { get; set; }
        public virtual ICollection<TaskTemplate> InverseSuperTaskTemplate { get; set; }
        public virtual ICollection<TaskTemplateCustomerXref> TaskTemplateCustomerXrefs { get; set; }
        public virtual ICollection<TaskTemplatePackageDetail> TaskTemplatePackageDetails { get; set; }
        public virtual ICollection<TaskTemplateSuccessorStatus> TaskTemplateSuccessorStatuses { get; set; }
        public virtual ICollection<TaskTemplateTriggerEventRuleXref> TaskTemplateTriggerEventRuleXrefs { get; set; }

        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
        public virtual ICollection<NotificationTemplate> NotificationTemplates { get; set; }
        public virtual ICollection<WorkGroup> WorkGroups { get; set; }
    }
}
