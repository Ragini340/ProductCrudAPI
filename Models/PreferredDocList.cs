using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PreferredDocList
    {
        public int PreferDocListId { get; set; }
        public int ClassTypeId { get; set; }
        public int PreferDocListEntityId { get; set; }
        public int DocTypeCdId { get; set; }
        public int DocOriginTypeCdId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
    }
}
