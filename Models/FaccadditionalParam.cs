using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FaccadditionalParam
    {
        public int FaccadditionalParamId { get; set; }
        public int ServiceFileFeeId { get; set; }
        public int ServicefileFeeFaccxrefId { get; set; }
        public int? CalculateFeeTypecdId { get; set; }
        public string FaccparamKey { get; set; } = null!;
        public string FaccparamCode { get; set; } = null!;
        public string Faccprompt { get; set; } = null!;
        public string FaccparamValue { get; set; } = null!;
        public string? FaccparamValueId { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? FaccparamValueType { get; set; }

        public virtual TypeCdDmt? CalculateFeeTypecd { get; set; }
        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
    }
}
