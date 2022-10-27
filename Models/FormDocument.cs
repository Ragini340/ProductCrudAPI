using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FormDocument
    {
        public FormDocument()
        {
            FieldElements = new HashSet<FieldElement>();
            InterfaceDeliveryRequests = new HashSet<InterfaceDeliveryRequest>();
        }

        public int FormdocumentId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string? Descr { get; set; }
        public int? FileId { get; set; }
        public string? RenderDocName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int TemplateId { get; set; }
        public int StatusCd { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? FilePathName { get; set; }
        public string? SpecialInstructions { get; set; }
        public int BusinessUnitId { get; set; }
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? PaperSizeTypeCdId { get; set; }
        public int? OrientationTypeCdId { get; set; }
        public int? FormTemplateId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ServiceFile? File { get; set; }
        public virtual FormTemplate? FormTemplate { get; set; }
        public virtual TypeCdDmt? OrientationTypeCd { get; set; }
        public virtual TypeCdDmt? PaperSizeTypeCd { get; set; }
        public virtual ICollection<FieldElement> FieldElements { get; set; }
        public virtual ICollection<InterfaceDeliveryRequest> InterfaceDeliveryRequests { get; set; }
    }
}
