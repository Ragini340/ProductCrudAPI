using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Swiftcode
    {
        public string Swiftcode1 { get; set; } = null!;
        public string CountryName { get; set; } = null!;
        public int IsInsertOrDelete { get; set; }
    }
}
