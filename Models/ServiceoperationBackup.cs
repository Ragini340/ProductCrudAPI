using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceoperationBackup
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Isdeleted { get; set; }
        public DateTime OperationDeletedDate { get; set; }
    }
}
