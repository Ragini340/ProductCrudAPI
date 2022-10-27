using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GfeimpoundDescription
    {
        public int GfeimpoundDescriptionId { get; set; }
        public int GfeloanTermId { get; set; }
        public string? Description { get; set; }
        public short? SeqNum { get; set; }
        public short? PaymentItemFlag { get; set; }

        public virtual GfeloanTerm GfeloanTerm { get; set; } = null!;
    }
}
