using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceOperationApplicationXrefBackup
    {
        public int OperationId { get; set; }
        public int ApplicationId { get; set; }
        public int StatusCd { get; set; }
        public int Isdeleted { get; set; }
        public DateTime OperationAppDeletedDate { get; set; }
    }
}
