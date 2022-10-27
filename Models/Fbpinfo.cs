using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Fbpinfo
    {
        public int FileId { get; set; }
        public int RoleType { get; set; }
        public string Idcode { get; set; } = null!;
        public string? Name { get; set; }
        public string? Location { get; set; }
    }
}
