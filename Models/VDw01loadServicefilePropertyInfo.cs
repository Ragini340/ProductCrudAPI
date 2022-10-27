using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadServicefilePropertyInfo
    {
        public int FileId { get; set; }
        public DateTime Dwdate { get; set; }
        public string? PropertyName { get; set; }
        public int? PropertyTypeObjectCd { get; set; }
        public string? PropertyTypeName { get; set; }
        public int Taxid { get; set; }
        public string? CityOfProperty { get; set; }
        public string? TaxNum { get; set; }
        public string? PropertyAddress1 { get; set; }
        public string? PropertyAddress2 { get; set; }
    }
}
