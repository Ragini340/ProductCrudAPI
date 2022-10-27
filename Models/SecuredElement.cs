using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SecuredElement
    {
        public int SecuredElementId { get; set; }
        public int? ScreenId { get; set; }
        public string? ElementIdentifier { get; set; }
        public int? BehaviourFlag { get; set; }
        public int? ActivityId { get; set; }
        public int? ActivityGrpId { get; set; }

        public virtual Activity? Activity { get; set; }
        public virtual ActivityGrp? ActivityGrp { get; set; }
        public virtual ScreenList? Screen { get; set; }
    }
}
