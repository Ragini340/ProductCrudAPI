using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SurveyInfo
    {
        public int FileProcessId { get; set; }
        public string? SurveyNote { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
    }
}
