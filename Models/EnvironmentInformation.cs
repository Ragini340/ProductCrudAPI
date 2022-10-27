using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EnvironmentInformation
    {
        public int Id { get; set; }
        public string EnvironmentName { get; set; } = null!;
        public string SettingName { get; set; } = null!;
        public string Value { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string? CreatedByUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedByUser { get; set; }
    }
}
