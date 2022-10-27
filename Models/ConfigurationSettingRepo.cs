using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ConfigurationSettingRepo
    {
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string Section { get; set; } = null!;
        public string Application { get; set; } = null!;
        public string Environment { get; set; } = null!;
        public string Release { get; set; } = null!;
        public int? Encrypted { get; set; }
        public string Tfs { get; set; } = null!;
        public string Comments { get; set; } = null!;
    }
}
