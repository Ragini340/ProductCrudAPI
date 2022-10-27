using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TimeDay
    {
        public int DwdayKey { get; set; }
        public DateTime? DayDt { get; set; }
        public int? DayOfWkNbr { get; set; }
        public int? DayInMthNbr { get; set; }
        public int? DayInYrNbr { get; set; }
        public string DayNm { get; set; } = null!;
        public string? DayAbbr { get; set; }
        public int? DayOvallNbr { get; set; }
        public string? WkDayFlg { get; set; }
        public int? WkInYrNbr { get; set; }
        public int? WkOvallNbr { get; set; }
        public DateTime? WkBegDt { get; set; }
        public int WkBegDtId { get; set; }
        public int? MthNbr { get; set; }
        public string MthNm { get; set; } = null!;
        public string? MthAbbr { get; set; }
        public int? QtrNbr { get; set; }
        public int? YrNbr { get; set; }
        public int? FiscMthNbr { get; set; }
        public int? FiscQtrNbr { get; set; }
        public int? FiscYrNbr { get; set; }
        public string? LastDayInMthFlg { get; set; }
        public int HolId { get; set; }
        public int SeasId { get; set; }
        public DateTime? ExtrctDt { get; set; }
        public DateTime EndOfDayTs { get; set; }
        public DateTime BegOfDayTs { get; set; }
    }
}
