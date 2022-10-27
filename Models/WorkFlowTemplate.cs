using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplate
    {
        public WorkFlowTemplate()
        {
            ProcessTemplateWebCustomerXrefs = new HashSet<ProcessTemplateWebCustomerXref>();
            TaskTemplates = new HashSet<TaskTemplate>();
            WorkFlowTemplateAdditionalRoleTypeXrefs = new HashSet<WorkFlowTemplateAdditionalRoleTypeXref>();
            WorkFlowTemplateApnxrefs = new HashSet<WorkFlowTemplateApnxref>();
            WorkFlowTemplateApplicationXrefs = new HashSet<WorkFlowTemplateApplicationXref>();
            WorkFlowTemplateBusOrgXrefs = new HashSet<WorkFlowTemplateBusOrgXref>();
            WorkFlowTemplateChangeHistories = new HashSet<WorkFlowTemplateChangeHistory>();
            WorkFlowTemplateOriginatorXrefs = new HashSet<WorkFlowTemplateOriginatorXref>();
            WorkFlowTemplateProductTypeXrefs = new HashSet<WorkFlowTemplateProductTypeXref>();
            WorkFlowTemplateProgramTypeXrefs = new HashSet<WorkFlowTemplateProgramTypeXref>();
            WorkFlowTemplateSearchTypeXrefs = new HashSet<WorkFlowTemplateSearchTypeXref>();
            WorkFlowTemplateServiceTypeXrefs = new HashSet<WorkFlowTemplateServiceTypeXref>();
        }

        public int WorkFlowTemplateId { get; set; }
        public string? Name { get; set; }
        public int? ServiceTypeCdId { get; set; }
        public string? Descr { get; set; }
        public DateTime CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public int? ProductTypeCdId { get; set; }
        public int BusinessUnitId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? RoleTypeCdId { get; set; }
        public byte EregFlag { get; set; }
        public byte ConversionRequiredFlag { get; set; }
        public int? UpdateEmployeeId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public short? StatusCd { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public int? StatusChangeUserId { get; set; }
        public string? Comments { get; set; }
        public short? IsOfficeGroup { get; set; }
        public DateTime? DeActivationDate { get; set; }
        public DateTime? ReActivationDate { get; set; }
        public short? Ucflag { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? ProcessTypeId { get; set; }
        public int? ProcessOwnerRegionId { get; set; }
        public short? IsPrioritizedFlag { get; set; }
        public int? ProcessAttributeCdId { get; set; }
        public byte? SourceRelationship { get; set; }
        public byte? OriginatorRelationship { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual BusinessUnit? ProcessOwnerRegion { get; set; }
        public virtual ProcessType? ProcessType { get; set; }
        public virtual TypeCdDmt? ProductTypeCd { get; set; }
        public virtual TypeCdDmt? RoleTypeCd { get; set; }
        public virtual Employee? UpdateEmployee { get; set; }
        public virtual ICollection<ProcessTemplateWebCustomerXref> ProcessTemplateWebCustomerXrefs { get; set; }
        public virtual ICollection<TaskTemplate> TaskTemplates { get; set; }
        public virtual ICollection<WorkFlowTemplateAdditionalRoleTypeXref> WorkFlowTemplateAdditionalRoleTypeXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateApnxref> WorkFlowTemplateApnxrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateApplicationXref> WorkFlowTemplateApplicationXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateBusOrgXref> WorkFlowTemplateBusOrgXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateChangeHistory> WorkFlowTemplateChangeHistories { get; set; }
        public virtual ICollection<WorkFlowTemplateOriginatorXref> WorkFlowTemplateOriginatorXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateProductTypeXref> WorkFlowTemplateProductTypeXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateProgramTypeXref> WorkFlowTemplateProgramTypeXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateSearchTypeXref> WorkFlowTemplateSearchTypeXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateServiceTypeXref> WorkFlowTemplateServiceTypeXrefs { get; set; }
    }
}
