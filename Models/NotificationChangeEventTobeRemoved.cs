using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NotificationChangeEventTobeRemoved
    {
        public int NotificationChangeEventId { get; set; }
        public int FileId { get; set; }
        public int? NotificationChangeTypeCdId { get; set; }
        public int StatusCd { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
