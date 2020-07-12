using R7.Applicants.Models;
using Xunit;

namespace R7.Applicants.Tests
{
    public class QueryTests
    {
        [Fact]
        public void CanQueryApplicantByName ()
        {
            var db = TestDatabase.Instance;
            var applicants = db.GetCollection<Applicant> ("Applicants").Find (
                ap => ap.Name.Contains ("Аспирант")
            );

            Assert.NotEmpty (applicants);
        }
    }
}
