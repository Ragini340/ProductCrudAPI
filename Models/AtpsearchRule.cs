using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AtpsearchRule
    {
        public int ClassTypeId { get; set; }
        public int TypeValue { get; set; }
        public int StatusCd { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
    }
}
