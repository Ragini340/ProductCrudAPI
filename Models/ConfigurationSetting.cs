using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ConfigurationSetting
    {
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string Section { get; set; } = null!;
        public string Application { get; set; } = null!;
        public int? Encrypted { get; set; }
    }
}
