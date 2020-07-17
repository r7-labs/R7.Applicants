using System;

namespace R7.Applicants.Models
{
    public class SourceFile
    {
        public int Id { get; set; }

        public string Filename { get; set; }

        public long Length { get; set; }

        public DateTime LastWriteTimeUtc { get; set; }
    }
}
