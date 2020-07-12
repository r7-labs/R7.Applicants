using System;
using R7.Applicants.Core;
using R7.Applicants.Tests.Data;

namespace R7.Applicants.Tests
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.Write (DatabaseDumper.DumpDatabase (TestDatabase.Instance));
        }
    }
}
