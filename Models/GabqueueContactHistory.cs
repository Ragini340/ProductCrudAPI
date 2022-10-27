using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GabqueueContactHistory
    {
        public int? GabqueueId { get; set; }
        public int? ContactId { get; set; }
        public int? RequestType { get; set; }
        public int GabqueueContactHistoryId { get; set; }

        public virtual BusOrgContact? Contact { get; set; }
        public virtual GabentryRequestQueue? Gabqueue { get; set; }
    }
}
