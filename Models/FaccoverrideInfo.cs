using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FaccoverrideInfo
    {
        public int FileId { get; set; }
        public int OverrideTypeCdId { get; set; }
        public string AssociatedFileNum { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt OverrideTypeCd { get; set; } = null!;
    }
}
