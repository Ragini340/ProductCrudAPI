using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchOrderDatum
    {
        public int SearchObjectId { get; set; }
        public string? TitleNum { get; set; }
        public string? BuyerName { get; set; }
        public string? SellerName { get; set; }
        public string? Address { get; set; }
        public string? RegionName { get; set; }
        public string? OwnerOfficeName { get; set; }
        public int? TitleEscrowInfoId { get; set; }
        public int? OrderId { get; set; }
        public int? StatusCode { get; set; }
        public string? ExternalFileNum { get; set; }
        public int? OwnerRegionId { get; set; }
        public int? OwnerOfficeId { get; set; }
        public string? ExternalId { get; set; }
    }
}
