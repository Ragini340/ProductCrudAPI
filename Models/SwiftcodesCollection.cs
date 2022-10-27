using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SwiftcodesCollection
    {
        public int Id { get; set; }
        public string Swiftcode { get; set; } = null!;
        public bool? IsIntlWire { get; set; }
        public string CountryName { get; set; } = null!;
    }
}
