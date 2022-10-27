using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FbpsearchVendorInfo
    {
        public FbpsearchVendorInfo()
        {
            FbpsearchVendorProblemLogs = new HashSet<FbpsearchVendorProblemLog>();
        }

        public int FileProcessId { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public int? ProductionProcess { get; set; }
        public decimal? Cost { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual ICollection<FbpsearchVendorProblemLog> FbpsearchVendorProblemLogs { get; set; }
    }
}
