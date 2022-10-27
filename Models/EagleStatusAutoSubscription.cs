using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EagleStatusAutoSubscription
    {
        public int Id { get; set; }
        public int? FileId { get; set; }
        public DateTime? ExecutionTime { get; set; }
        public bool? StatusCd { get; set; }
    }
}
