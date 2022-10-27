using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RecordingInfo
    {
        public int RecordingInfoId { get; set; }
        public int ClassTypeId { get; set; }
        public int PropertyId { get; set; }
        public string MapNum { get; set; } = null!;
        public DateTime? MapDate { get; set; }
        public string? Page { get; set; }
        public string? Block { get; set; }
        public int? TypeCdId { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual RealProperty Property { get; set; } = null!;
        public virtual TypeCdDmt? TypeCd { get; set; }
    }
}
