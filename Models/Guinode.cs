using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Guinode
    {
        public Guinode()
        {
            GuinodeCustomizations = new HashSet<GuinodeCustomization>();
            InverseParentNode = new HashSet<Guinode>();
        }

        public int NodeId { get; set; }
        public int ClassTypeId { get; set; }
        public int? ParentNodeId { get; set; }
        public string NodeName { get; set; } = null!;
        public int SeqNum { get; set; }
        public short TitleFlag { get; set; }
        public short EscrowFlag { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Guinode? ParentNode { get; set; }
        public virtual ICollection<GuinodeCustomization> GuinodeCustomizations { get; set; }
        public virtual ICollection<Guinode> InverseParentNode { get; set; }
    }
}
