using R7.Applicants.Tests.Data;
using Xunit;

namespace R7.Applicants.Tests.Parsers
{
    public class WorkbookParserTests
    {
        [Fact]
        public void CreateTestDatabaseTest ()
        {
            var db = TestDatabase.Instance;
            Assert.NotNull (db);
        }
    }
}
