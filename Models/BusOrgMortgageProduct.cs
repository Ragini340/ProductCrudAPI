using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgMortgageProduct
    {
        public int BusOrgMortgageProductId { get; set; }
        public int BusOrgId { get; set; }
        public int MortgageProductTypeCdId { get; set; }
        public int LoanTypeCdId { get; set; }
        public int StatusCd { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual TypeCdDmt LoanTypeCd { get; set; } = null!;
        public virtual TypeCdDmt MortgageProductTypeCd { get; set; } = null!;
    }
}
