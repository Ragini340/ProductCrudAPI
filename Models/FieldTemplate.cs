using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FieldTemplate
    {
        public FieldTemplate()
        {
            FieldElements = new HashSet<FieldElement>();
        }

        public int FieldTemplateId { get; set; }
        public int ClassTypeId { get; set; }
        public string? Descr { get; set; }
        public string? KeyField { get; set; }
        public int? DataElementId { get; set; }
        public int? FlowRuleTypeCdid { get; set; }
        public int? DisplayTypeCdId { get; set; }
        public string? MoveToKeyField { get; set; }
        public string? FloatKeyField { get; set; }
        public string? OverFlowKeyField { get; set; }
        public string? CopyToKeyField { get; set; }
        public int? StatusCd { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? FormTemplateId { get; set; }
        public string? FormatCode { get; set; }
        public string? CustomSupplKey { get; set; }
        public string? CustomFloatKey { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual DataElementDmt? DataElement { get; set; }
        public virtual TypeCdDmt? DisplayTypeCd { get; set; }
        public virtual TypeCdDmt? FlowRuleTypeCd { get; set; }
        public virtual FormTemplate? FormTemplate { get; set; }
        public virtual ICollection<FieldElement> FieldElements { get; set; }
    }
}
