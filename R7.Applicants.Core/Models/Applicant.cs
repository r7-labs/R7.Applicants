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

        public int? Exam1Rate { get; set; }

        public int? Exam2Rate { get; set; }

        public int? Exam3Rate { get; set; }

        public int? PaRate { get; set; }

        public int? Rate { get; set; }

        public int CategoryId { get; set; }
    }
}
