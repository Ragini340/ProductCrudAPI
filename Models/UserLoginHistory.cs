using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UserLoginHistory
    {
        public int? EmployeeId { get; set; }
        public DateTime? LoginDate { get; set; }
        public string? HostName { get; set; }
        public int Type { get; set; }
        public string? Comments { get; set; }
        public int UserLoginHistoryId { get; set; }
        public string? LoginName { get; set; }
        public int? StatusCd { get; set; }
        public string? ModuleType { get; set; }
        public DateTime? LogoutDate { get; set; }
        public string? ClientMachineIp { get; set; }
        public string? BrowserInfo { get; set; }
        public string? UserAgentInfo { get; set; }

        public virtual TypeCdDmt? StatusCdNavigation { get; set; }
    }
}
