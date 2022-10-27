using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EcheckEmailList
    {
        public int EcheckEmailListId { get; set; }
        public string EmailId { get; set; } = null!;
        public string? Name { get; set; }
    }
}
