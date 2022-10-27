using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileAttribute
    {
        public int ServiceFileAttributeId { get; set; }
        public int FileId { get; set; }
        public int NameTypeCdId { get; set; }
        public string Value { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt NameTypeCd { get; set; } = null!;
    }
}
