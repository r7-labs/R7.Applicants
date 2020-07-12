namespace R7.Applicants.Models
{
    public class Applicant
    {
        public int Id { get; set; }

        public int? Order { get; set; }

        public string Name { get; set; }

        public bool HasOriginal { get; set; }

        public bool HasAgreement { get; set; }

        public int EduProgramId { get; set; }

        public int EduFormId { get; set; }

        public int FinancingId { get; set; }

        public decimal? Exam1Rate { get; set; }

        public decimal? Exam2Rate { get; set; }

        public string Exam2Mark { get; set; }

        public decimal? Exam3Rate { get; set; }

        public decimal? AchRate { get; set; }

        public decimal? TotalRate { get; set; }

        public string Category { get; set; }
    }
}
