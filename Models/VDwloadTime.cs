using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadTime
    {
        public DateTime? Dwdate { get; set; }
        public int? DayOfWeek { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? Quarter { get; set; }
        public int? DayOfYear { get; set; }
        public int? YearMonth { get; set; }
    }
}
