using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FloridaDisclosureOverrideName
    {
        public int FdoverrideNameId { get; set; }
        public int FileId { get; set; }
        public bool? UnderWriterOverrideFlag { get; set; }
        public bool? OwningOfficeOverrideFlag { get; set; }
        public string? UnderWriterOverrideName { get; set; }
        public string? OwningOfficeOverrideName { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
    }
}
