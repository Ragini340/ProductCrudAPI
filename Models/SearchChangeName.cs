using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchChangeName
    {
        public long ChangeId { get; set; }
        public int ObjectId { get; set; }
        public int ObjectPk { get; set; }
    }
}
