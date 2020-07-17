using System;

namespace R7.Applicants.Tests
{
    class Program
    {
        static void Main (string [] args)
        {
            var db = TestDatabase.CreateTestDatabase ("./test-data");
            Console.Write (DatabaseDumper.DumpDatabase (db));
        }
    }
}
