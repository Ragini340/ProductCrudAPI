using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LrhOrder
    {
        public int? DwordrKey { get; set; }
        public string? FileNbr { get; set; }
        public int? FastStatCdId { get; set; }
        public short? BaseFileFlg { get; set; }
        public DateTime? StatChgDt { get; set; }
        public string? StatCdDesc { get; set; }
        public int? FastEscrwOwnOffcId { get; set; }
        public int? FastTtlOwnOffcId { get; set; }
        public DateTime? SettlDt { get; set; }
        public DateTime? OrdrCloseDt { get; set; }
        public DateTime? PrimCloseApptDt { get; set; }
        public string? PrimCloseApptTm { get; set; }
        public int LrhOrdersId { get; set; }
    }
}
