using System;

namespace R7.Applicants.Models
{
    public class DbInfo
    {
        public int Id { get; set; }

        public DateTime GeneratedTimeUtc { get; set; }

        public string GeneratedWithAppVersion { get; set; }
    }
}
