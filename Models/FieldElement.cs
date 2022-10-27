using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FieldElement
    {
        public int FieldElementId { get; set; }
        public string? Value { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int FormdocumentId { get; set; }
        public int FieldTemplateId { get; set; }

        public virtual FieldTemplate FieldTemplate { get; set; } = null!;
        public virtual FormDocument Formdocument { get; set; } = null!;
    }
}
