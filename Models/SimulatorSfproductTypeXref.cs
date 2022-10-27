using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SimulatorSfproductTypeXref
    {
        public int SimulatorSfproductTypeXrefId { get; set; }
        public int? FileId { get; set; }
        public int ProductTypeCdId { get; set; }
        public byte[]? Updts { get; set; }
    }
}
