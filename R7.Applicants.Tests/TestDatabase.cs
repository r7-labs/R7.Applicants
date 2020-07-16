using System;
using System.IO;
using LiteDB;
using R7.Applicants.Parsers;

namespace R7.Applicants.Tests
{
    public static class TestDatabase
    {
        const string TEST_DATABASE_FILE = "./test.db";
        const string TEST_DATABASE_LOG_FILE = "./test-log.db";

        public static readonly ILiteDatabase Instance = new Lazy<LiteDatabase> (() => CreateTestDatabase ("../../../test-data")).Value;

        public static LiteDatabase CreateTestDatabase (string path)
        {
            if (File.Exists (TEST_DATABASE_FILE)) {
                File.Delete (TEST_DATABASE_FILE);
            }

            if (File.Exists (TEST_DATABASE_LOG_FILE)) {
                File.Delete (TEST_DATABASE_LOG_FILE);
            }

            var db = new LiteDatabase (TEST_DATABASE_FILE);

            var workbookParser = new WorkbookParser (db);
            var listFiles = Directory.GetFiles (path, "*.xls");
            foreach (var listFile in listFiles) {
                workbookParser.ParseTo (listFile, db);
            }

            return db;
        }
    }
}
