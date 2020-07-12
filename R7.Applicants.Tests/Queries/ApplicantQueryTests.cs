using R7.Applicants.Models;
using Xunit;

namespace R7.Applicants.Tests.Queries
{
    public class ApplicantQueryTests
    {
        [Fact]
        public void ApplicantQueryByNameTest ()
        {
            var db = TestDatabase.Instance;
            var applicants = db.GetCollection<Applicant> ("Applicants").Find (
                ap => ap.Name.Contains ("Аспирант")
            );

            Assert.NotEmpty (applicants);
        }
    }
}
