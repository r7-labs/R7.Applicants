using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LiteDB;
using R7.Applicants.Models;

namespace R7.Applicants.Data
{
    /// <summary>
    /// Manages creation of database and ensures that clients will have access to the actual database only
    /// </summary>
    public class ApplicantsDatabaseProducer
    {
        public ILiteDatabase GetDatabase (string path)
        {
            throw new NotImplementedException ();

            // TODO: Implementation plan
            // 1. Build list of database files ordered by create/last modified time
            // 2. Check if first database is actual - if so, return the reference
            // 3. If not, then build new database from source files and then return the reference
        }

        public bool DatabaseIsActual (ILiteDatabase db, string srcPath)
        {
            var srcFiles = Directory.GetFiles (srcPath, "*.xls");
            return DatabaseIsActual (db, srcFiles.Select (f => new FileInfo (f)));
        }

        // TODO: Take current app version into account
        public bool DatabaseIsActual (ILiteDatabase db, IEnumerable<FileInfo> srcFiles)
        {
            var dbSrcFiles = db.GetCollection<SourceFile> ("SourceFiles");
            if (srcFiles.Count () != dbSrcFiles.Count ()) {
                return false;
            }

            foreach (var srcFile in srcFiles) {
                var dbSrcFile = dbSrcFiles.FindOne (sf => sf.Filename.Equals (srcFile.Name, StringComparison.CurrentCultureIgnoreCase)
                    && sf.Length == srcFile.Length
                    && sf.LastWriteTimeUtc == srcFile.LastWriteTimeUtc);
                if (dbSrcFile == null) {
                    return false;
                }
            }
            return true;
        }
    }
}
