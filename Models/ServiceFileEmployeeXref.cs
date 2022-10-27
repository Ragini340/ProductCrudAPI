using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileEmployeeXref
    {
        public int FunctionTypeCdId { get; set; }
        public int FileId { get; set; }
        public int EmployeeId { get; set; }
        public int? StateLicenseInformationId { get; set; }
        public string? StateLicenseNo { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt FunctionTypeCd { get; set; } = null!;
    }
}
