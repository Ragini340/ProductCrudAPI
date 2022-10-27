using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CustomDictionary
    {
        public int WordId { get; set; }
        public string Word { get; set; } = null!;
    }
}
