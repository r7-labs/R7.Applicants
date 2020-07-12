using System.Linq;
using R7.Applicants.Models;
using R7.Applicants.Tests.Data;
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
                ap => ap.Name == "Аспирант 1"
            );

            Assert.NotEmpty (applicants);
            Assert.Equal (2, applicants.Count ());
        }
    }
}
