using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SplitLspgfe4
    {
        public int FileId { get; set; }
        public int? Lsp1flag { get; set; }
        public int? Lsp2flag { get; set; }
        public int? Lsp3flag { get; set; }
        public int? Lsp4flag { get; set; }
        public int? Lsp5flag { get; set; }
        public int? Lsp6flag { get; set; }
        public decimal? SplitGfe1 { get; set; }
        public decimal? SplitGfe2 { get; set; }
        public decimal? SplitGfe3 { get; set; }
        public decimal? SplitGfe4 { get; set; }
        public decimal? SplitGfe5 { get; set; }
        public decimal? SplitGfe6 { get; set; }
        public short? IsModified { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
