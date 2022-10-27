using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocIdforPurge
    {
        public int DocId { get; set; }
        public int? ElectronicFileId { get; set; }
        public DateTime? DeploymentDate { get; set; }
        public string? Comments { get; set; }
    }
}
