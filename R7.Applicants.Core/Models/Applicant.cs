namespace R7.Applicants.Core.Models
{
    public class Applicant
    {
        public int Id { get; set; }

        public int? Order { get; set; }

        public string Name { get; set; }

        public bool OriginalOrCopy { get; set; }

        public bool Consent { get; set; }

        public int EduProgramId { get; set; }

        public int EduFormId { get; set; }

        public decimal? Exam1Rate { get; set; }

        public decimal? Exam2Rate { get; set; }

        public string Exam2Mark { get; set; }

        public decimal? Exam3Rate { get; set; }

        public decimal? PaRate { get; set; }

        public decimal? Rate { get; set; }

        public int CategoryId { get; set; }
    }
}
