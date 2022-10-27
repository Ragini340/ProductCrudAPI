using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SimulatorTask
    {
        public int TaskId { get; set; }
        public int? ServiceTypeCdId { get; set; }
        public int TaskCategoryId { get; set; }
        public int? StatusCd { get; set; }
        public string? Name { get; set; }
        public int? OwnerId { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string? ExternalFileNum { get; set; }
        public int? SeqNum { get; set; }
        public short AlertOnCompleteFlag { get; set; }
        public DateTime? WarnDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime CreationDate { get; set; }
        public int WorkFlow2Id { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comment { get; set; }
        public int? DueDateTypeCdId { get; set; }
        public short? WarnDays { get; set; }
        public short? DueDays { get; set; }
        public short? AlertedForWarnDateFlag { get; set; }
        public short? AlertedForDueDateFlag { get; set; }
        public DateTime? OwnerAssignDate { get; set; }
        public int DueDateOrder { get; set; }
        public string? EmployeeHomeOfficeName { get; set; }
        public int? SourceApplId { get; set; }
        public DateTime? WaiveDate { get; set; }
        public byte? IsPrivate { get; set; }
        public int? WarnHours { get; set; }
        public int? WarnMinutes { get; set; }
        public int? DueHours { get; set; }
        public int? DueMinutes { get; set; }
        public int? TaskEventId { get; set; }
        public int? FileEventId { get; set; }
        public int? FileEventStatusCd { get; set; }
        public int? TaskTemplateId { get; set; }
        public int? SuccessorStatusCd { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? ImportCount { get; set; }
        public DateTime? ActivateDate { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public int? SuperTaskTemplateId { get; set; }
        public int? TaskEventRuleId { get; set; }
        public DateTime? InitialAssignDate { get; set; }
        public int TaskOfficeId { get; set; }
        public DateTime? TaskOfficeAssignDate { get; set; }
        public int? WorkgroupId { get; set; }
        public DateTime? WorkgroupAssignDate { get; set; }
        public int? InitialOfficeId { get; set; }
        public DateTime? InitialOfficeAssignDate { get; set; }
        public int? InitialWorkgroupId { get; set; }
        public DateTime? InitialWorkgroupAssignDate { get; set; }
        public int? InitialOwnerId { get; set; }
        public DateTime? InitialOwnerAssignDate { get; set; }
        public int? FileEventRuleId { get; set; }
        public int? TaskEventStatusCd { get; set; }
        public int? ServiceFileProcessId { get; set; }
    }
}
