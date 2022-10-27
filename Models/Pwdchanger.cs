using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Pwdchanger
    {
        public int ConfigId { get; set; }
        public string ConfigName { get; set; } = null!;
        public string ConfigXml { get; set; } = null!;
    }
}
