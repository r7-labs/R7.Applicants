using System.IO;
using LiteDB;
using R7.Applicants.Core;
using R7.Applicants.Core.Parsers;

namespace R7.Applicants
{
    class Program
    {
        static void Main (string [] args)
        {
            var db = new LiteDatabase ("./lite.db");

            var workbookParser = new WorkbookParser (db);
            workbookParser.ParseTo ("./data/bak.xls", db);
            workbookParser.ParseTo ("./data/bak-spec.xls", db);
            workbookParser.ParseTo ("./data/ino.xls", db);
            workbookParser.ParseTo ("./data/asp.xls", db);

            DatabaseDumper.DumpDatabase (db);

            db.Dispose ();
            File.Delete ("./lite.db");
        }
    }
}
