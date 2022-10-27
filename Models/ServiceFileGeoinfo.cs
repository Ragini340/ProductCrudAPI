using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileGeoinfo
    {
        public int PhysicalAddrId { get; set; }
        public int? FileId { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? County { get; set; }
        public string? City { get; set; }
        public int? PropertyTypeCdId { get; set; }
    }
}
