using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GuinodeCustomization
    {
        public int NodeCustomizationId { get; set; }
        public int ClassTypeId { get; set; }
        public int NodeId { get; set; }
        public int BusinessUnitId { get; set; }
        public int TransTypeCdId { get; set; }
        public int SeqNum { get; set; }
        public short TitleFlag { get; set; }
        public short EscrowFlag { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Guinode Node { get; set; } = null!;
        public virtual TypeCdDmt TransTypeCd { get; set; } = null!;
    }
}
