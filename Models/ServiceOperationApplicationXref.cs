using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceOperationApplicationXref
    {
        public int OperationId { get; set; }
        public int ApplicationId { get; set; }
        public int StatusCd { get; set; }

        public virtual Application Application { get; set; } = null!;
        public virtual ServiceOperation Operation { get; set; } = null!;
    }
}
