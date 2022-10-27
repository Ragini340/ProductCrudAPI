using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RegionFlag
    {
        public int RegionFlagId { get; set; }
        public int UserId { get; set; }
        public int RegionId { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
