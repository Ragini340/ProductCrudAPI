using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TransactionTypeStateXref
    {
        public int TransactionTypeId { get; set; }
        public string StateCd { get; set; } = null!;
        public int StatusCd { get; set; }
    }
}
