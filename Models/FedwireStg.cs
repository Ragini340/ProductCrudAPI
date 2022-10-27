using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FedwireStg
    {
        public string? RoutingNumber { get; set; }
        public string? Tname { get; set; }
        public string? Cname { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Ftstatus { get; set; }
        public string? Fsstatus { get; set; }
        public string? Boestatus { get; set; }
        public DateTime? LastRevisionDate { get; set; }
        public string? Bdate { get; set; }
        public int FedwireStgId { get; set; }
    }
}
