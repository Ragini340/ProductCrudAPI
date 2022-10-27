using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Facc2ndLevelParamMap
    {
        public int ParamMapId { get; set; }
        public int ParamCode { get; set; }
        public string PropertyName { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;
    }
}
