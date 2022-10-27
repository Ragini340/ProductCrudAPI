using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BigIntConvertedArchiveDb
    {
        public int Dbyear { get; set; }
        public int Dbqtr { get; set; }
        public DateTime? DateConverted { get; set; }
    }
}
