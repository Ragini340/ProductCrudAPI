using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EclipseDbversion
    {
        public string Version { get; set; } = null!;
        public DateTime BuildDate { get; set; }
    }
}
