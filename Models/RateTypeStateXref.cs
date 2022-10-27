using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RateTypeStateXref
    {
        public int RateTypeId { get; set; }
        public string StateCd { get; set; } = null!;
        public short? DefaultRateType { get; set; }
        public int StatusCd { get; set; }
    }
}
