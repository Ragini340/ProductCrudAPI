using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FormTemplate
    {
        public FormTemplate()
        {
            FieldTemplates = new HashSet<FieldTemplate>();
            FormDocuments = new HashSet<FormDocument>();
        }

        public int FormTemplateId { get; set; }
        public int? PrinterTypeCdId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string? Descr { get; set; }
        public int StatusCd { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? Comments { get; set; }
        public string? FilePathName { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? PaperSizeTypeCdId { get; set; }
        public int? OrientationTypeCdId { get; set; }
        public int? DocTypeCdId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt? DocTypeCd { get; set; }
        public virtual TypeCdDmt? OrientationTypeCd { get; set; }
        public virtual TypeCdDmt? PaperSizeTypeCd { get; set; }
        public virtual TypeCdDmt? PrinterTypeCd { get; set; }
        public virtual ICollection<FieldTemplate> FieldTemplates { get; set; }
        public virtual ICollection<FormDocument> FormDocuments { get; set; }
    }
}
