using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NonWorkStd
    {
        public string? NonWorkClsNm { get; set; }
        public int? FastbusUnitId { get; set; }
        public string? DayTypDesc { get; set; }
        public string? RsnTypDesc { get; set; }
        public string? NonWorkUserCd { get; set; }
        public DateTime? NonWorkDt { get; set; }
        public string? NonWorkCmnt { get; set; }
        public int NonWorkStdId { get; set; }
    }
}
