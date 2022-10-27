using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class HoldFundInfo
    {
        public int FileProcessId { get; set; }
        public DateTime? HoldDate { get; set; }
        public short? ReleaseInDay { get; set; }
        public DateTime? EstReleaseDate { get; set; }
        public DateTime? ActualReleaseDate { get; set; }
        public short? AgreementFlag { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
    }
}
