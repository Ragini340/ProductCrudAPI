using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NameValueSetting
    {
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
        public string? EnvironmentName { get; set; }

        public virtual Environment? EnvironmentNameNavigation { get; set; }
    }
}
