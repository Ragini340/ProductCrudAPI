using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PersonWebCustomerXref
    {
        public int PersonId { get; set; }
        public int WebCustomerTypeCdId { get; set; }
        public short PublishFlag { get; set; }

        public virtual Person Person { get; set; } = null!;
        public virtual TypeCdDmt WebCustomerTypeCd { get; set; } = null!;
    }
}
