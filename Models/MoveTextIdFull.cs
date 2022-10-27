using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class MoveTextIdFull
    {
        public int TextId { get; set; }
        public int ClassTypeId { get; set; }
        public string TextData { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;
    }
}
