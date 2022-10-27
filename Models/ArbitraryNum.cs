using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ArbitraryNum
    {
        public int ArbitraryNumId { get; set; }
        public int ClassTypeId { get; set; }
        public int PropertyId { get; set; }
        public string? ArbitraryNum1 { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual RealProperty Property { get; set; } = null!;
    }
}
