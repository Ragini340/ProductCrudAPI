using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ScreenActivityActivityGrpXref
    {
        public int? ScreenId { get; set; }
        public int? ActivityId { get; set; }
        public int? ActivityGrpId { get; set; }
        public int ScreenActivityActivityGrpXrefId { get; set; }

        public virtual Activity? Activity { get; set; }
        public virtual ActivityGrp? ActivityGrp { get; set; }
        public virtual ScreenList? Screen { get; set; }
    }
}
