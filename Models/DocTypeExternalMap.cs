using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocTypeExternalMap
    {
        public int? DocTypeCdId { get; set; }
        public int? ExternalDocTypeCdId { get; set; }
        public int? ExternalAppId { get; set; }
        public int? TypeCdId { get; set; }
        public string? TableName { get; set; }
        public string? DatabaseName { get; set; }
        public int DocTypeExternalMapId { get; set; }
    }
}
