using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentGridFileAndScreenGridFilter
    {
        public int ScreenGridFilterId { get; set; }
        public int FileId { get; set; }
        public int ScreenId { get; set; }
        public int GridId { get; set; }
        public int DocumentGuifilterMasterId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? FilterData { get; set; }

        public virtual DocumentGuifilterMaster DocumentGuifilterMaster { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual FastSceenGridScreenListXref Grid { get; set; } = null!;
        public virtual ScreenList Screen { get; set; } = null!;
    }
}
