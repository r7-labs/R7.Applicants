using System.IO;
using System.Linq;
using R7.Applicants.Data;
using Xunit;

namespace R7.Applicants.Tests.Data
{
    public class ApplicationDatabaseProducerTests
    {
        [Fact]
        public void DatabaseIsActual ()
        {
            var db = TestDatabase.Instance;
            var dbProducer = new ApplicantsDatabaseProducer ();
            Assert.True (dbProducer.DatabaseIsActual (db, "../../../test-data"));
        }

        [Fact]
        public void DatabaseCanBeNotActual ()
        {
            var db = TestDatabase.Instance;
            var dbProducer = new ApplicantsDatabaseProducer ();
            var srcFiles = Directory.GetFiles ("../../../test-data", "*.xls").Select (f => new FileInfo (f)).ToList ();
            srcFiles.Add (new FileInfo ("R7.Applicants.Tests.dll"));
            Assert.False (dbProducer.DatabaseIsActual (db, srcFiles));
        }
    }
}
