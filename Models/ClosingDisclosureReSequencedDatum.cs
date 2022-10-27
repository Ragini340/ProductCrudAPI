using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ClosingDisclosureReSequencedDatum
    {
        public int ClosingDisclosureReSequencedDataId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public string? Section { get; set; }
        public string? LineNumber { get; set; }
        public int? EntityTypeCdId { get; set; }
        public int? EntityId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? SubSectionTypeCdId { get; set; }

        public virtual ClosingDisclosure? ClosingDisclosure { get; set; }
    }
}
