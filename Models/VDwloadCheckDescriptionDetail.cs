﻿using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadCheckDescriptionDetail
    {
        public int CheckDescriptionDetailId { get; set; }
        public string Description { get; set; } = null!;
        public string? CheckVoucherInfo { get; set; }
    }
}
