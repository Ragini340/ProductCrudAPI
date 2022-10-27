using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UserGuipreference
    {
        public int UserGuipreferencesId { get; set; }
        public int UserId { get; set; }
        public int GridId { get; set; }
        public byte PagingFlag { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual FastSceenGridScreenListXref Grid { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
    }
}
