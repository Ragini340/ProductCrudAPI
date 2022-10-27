using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UserRegionActivity
    {
        public int UserId { get; set; }
        public int RegionId { get; set; }
        public int ActivityId { get; set; }
        public int UserRegionActivityId { get; set; }
    }
}
