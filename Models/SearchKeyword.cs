using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchKeyword
    {
        public int KeywordId { get; set; }
        public string Value { get; set; } = null!;
    }
}
