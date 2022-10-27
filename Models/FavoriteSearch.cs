using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FavoriteSearch
    {
        public int FavoriteSearchId { get; set; }
        public int EmployeeId { get; set; }
        public string SearchName { get; set; } = null!;
        public int? SearchScopeTypeCdId { get; set; }
        public int? TemplateTypeCdId { get; set; }
        public string? Regions { get; set; }
        public string? States { get; set; }
        public string? Keywords { get; set; }
        public string? TransactionTypes { get; set; }
        public string? TemplateDescription { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public bool? IsPrimary { get; set; }
    }
}
