using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileSpeciallAttentionXref
    {
        public int FileId { get; set; }
        public short SpecialAttention { get; set; }
        public string SplAttentionComment { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
    }
}
