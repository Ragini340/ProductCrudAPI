using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CdprojectedPaymentRange
    {
        public int CdprojectedPaymentRangeId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public byte? YearRange { get; set; }
        public short? StartRange { get; set; }
        public short? EndRange { get; set; }
        public decimal? MinPrincipal { get; set; }
        public decimal? MaxPrincipal { get; set; }
        public decimal? Interest { get; set; }
        public string? MortgageInsurance { get; set; }
        public string? EstimatedEscrow { get; set; }
        public decimal? PricipalInterest { get; set; }
        public byte? IsInterestOnly { get; set; }
        public byte? IsMortgageInsuranceDefault { get; set; }
        public byte? IsEstimatedEscrowDefault { get; set; }
        public byte? IsMinMaxPrincipalOnly { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClosingDisclosure? ClosingDisclosure { get; set; }
    }
}
