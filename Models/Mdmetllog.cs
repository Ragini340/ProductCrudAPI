using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Mdmetllog
    {
        public int MdmetllogId { get; set; }
        public byte? LogTypeId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDatetime { get; set; }
    }
}
