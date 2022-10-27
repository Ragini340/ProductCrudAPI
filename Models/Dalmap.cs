using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Dalmap
    {
        public string SpName { get; set; } = null!;
        public string? Connection { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
