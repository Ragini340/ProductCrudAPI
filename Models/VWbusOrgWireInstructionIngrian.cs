using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VWbusOrgWireInstructionIngrian
    {
        public int WireInstId { get; set; }
        public string? BankName { get; set; }
        public string? BankAddr { get; set; }
        public string? Abanum { get; set; }
        public string? AcctNum { get; set; }
        public string? BranchTransitNum { get; set; }
        public string? Ficode { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? AcctNum2 { get; set; }
    }
}
