using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FastSceenGridScreenListXref
    {
        public FastSceenGridScreenListXref()
        {
            DocumentGridFileAndScreenGridFilters = new HashSet<DocumentGridFileAndScreenGridFilter>();
            UserGuipreferences = new HashSet<UserGuipreference>();
        }

        public int FastSceenGridId { get; set; }
        public string GridName { get; set; } = null!;
        public int ScreenId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ScreenList Screen { get; set; } = null!;
        public virtual ICollection<DocumentGridFileAndScreenGridFilter> DocumentGridFileAndScreenGridFilters { get; set; }
        public virtual ICollection<UserGuipreference> UserGuipreferences { get; set; }
    }
}
