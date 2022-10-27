using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ExternalFileService
    {
        public int ExternalFileServiceId { get; set; }
        public int FileId { get; set; }
        public int ServiceTypeCdId { get; set; }
        public DateTime DateCreated { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt ServiceTypeCd { get; set; } = null!;
    }
}
