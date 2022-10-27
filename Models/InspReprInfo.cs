using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InspReprInfo
    {
        public int FileProcessId { get; set; }
        public int FurnishedByTypeCdId { get; set; }
        public short? WithinDays { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public DateTime? ReportDate { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual TypeCdDmt FurnishedByTypeCd { get; set; } = null!;
    }
}
