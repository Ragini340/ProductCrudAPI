using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BulletinBoard
    {
        public byte FrameNumber { get; set; }
        public string ImageName { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime? BulletinBoardDate { get; set; }
        public DateTime? ReleaseNotesDate { get; set; }
        public string? ReleaseNotesUrl { get; set; }
    }
}
