using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FacctransactionDetail
    {
        public int Id { get; set; }
        public int? FileId { get; set; }
        public Guid Guid { get; set; }
        public string? Ccrequest { get; set; }
        public string? Ccresponse { get; set; }
        public string? CcresponseJson { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
