using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CddeliveryOption
    {
        public int FileId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public string? CddeliveryComments { get; set; }
        public short CddeliveryIsaddComments { get; set; }
        public int? IsCdformDelivered { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
    }
}
