using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbatransactionStatusLog
    {
        public long IbatransactionStatusLogId { get; set; }
        public int IbatransactionId { get; set; }
        public int StatusCdId { get; set; }
        public string? StatusChgComments { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public string? RequestData { get; set; }
        public string? ResponseData { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual Ibatransaction Ibatransaction { get; set; } = null!;
        public virtual TypeCdDmt StatusCd { get; set; } = null!;
    }
}
