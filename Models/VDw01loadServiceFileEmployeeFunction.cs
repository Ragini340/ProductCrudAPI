using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadServiceFileEmployeeFunction
    {
        public int FileId { get; set; }
        public DateTime? Dwdate { get; set; }
        public int EmployeeId { get; set; }
        public string FunctionTypeObjectCd { get; set; } = null!;
        public string? FunctionTypeName { get; set; }
    }
}
