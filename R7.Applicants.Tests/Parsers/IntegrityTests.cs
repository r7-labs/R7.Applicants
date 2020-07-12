using R7.Applicants.Models;
using Xunit;

namespace R7.Applicants.Tests
{
    public class IntegrityTests
    {
        [Fact]
        public void DatabaseContainsApplicants ()
        {
            var db = TestDatabase.Instance;
            var applicants = db.GetCollection<Applicant> ("Applicants").FindAll ();
            Assert.NotEmpty (applicants);
        }

        [Fact]
        public void DatabaseContainsEduPrograms ()
        {
            var db = TestDatabase.Instance;
            var eduPrograms = db.GetCollection<EduProgram> ("EduPrograms").FindAll ();
            Assert.NotEmpty (eduPrograms);
        }

        [Fact]
        public void AllEduProgramsHasExamTitles ()
        {
            var db = TestDatabase.Instance;
            var eduPrograms = db.GetCollection<EduProgram> ("EduPrograms").Find (
                ep => ep.Exam1Title == null && ep.Exam2Title == null && ep.Exam3Title == null
            );

            Assert.Empty (eduPrograms);
        }

        [Fact]
        public void AllEduProgramsAreUnique ()
        {
            var db = TestDatabase.Instance;
            var eduPrograms = db.GetCollection<EduProgram> ("EduPrograms");
            foreach (var eduProgram in eduPrograms.FindAll ()) {
                var duplicateEduPrograms = eduPrograms.Find (ep => ep.Title == eduProgram.Title
                    && ep.ProfileTitle == eduProgram.ProfileTitle
                    && ep.DivisionId == eduProgram.DivisionId
                    && ep.EduLevelId == eduProgram.EduLevelId
                    && ep.Id != eduProgram.Id
                );
                Assert.Empty (duplicateEduPrograms);         
            }
        }

        [Fact]
        public void AllApplicantsWithOriginalHaveRankedOrder ()
        {
            var db = TestDatabase.Instance;
            var applicants = db.GetCollection<Applicant> ("Applicants");
            var unrankedApplicants = applicants.Find (ap => ap.HasOriginal && ap.RankedOrder == null);
            Assert.Empty (unrankedApplicants);
        }
    }
}
