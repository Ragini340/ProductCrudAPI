using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CustomerPreference
    {
        public int PreferenceId { get; set; }
        public int UserId { get; set; }
        public string? BasicPreference { get; set; }
        public string? AdvancedPreference { get; set; }

        public virtual Employee User { get; set; } = null!;
    }
}
