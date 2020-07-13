using System;
using LiteDB;

namespace R7.Applicants.Tests
{
    class Program
    {
        static void Main (string [] args)
        {
            var db = GetTestDatabase (args);
            Console.Write (DatabaseDumper.DumpDatabase (db));
        }

        static ILiteDatabase GetTestDatabase (string [] args)
        {
            if (args.Length > 0 && args [0].StartsWith ("--path=", StringComparison.InvariantCultureIgnoreCase)) {
                return TestDatabase.CreateTestDatabase (args [0].Substring ("--path=".Length));
            }
            return TestDatabase.Instance;
        }
    }
}
