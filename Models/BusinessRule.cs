using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessRule
    {
        public int BusinessRuleId { get; set; }
        public string? BusinessRuleDescr { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
