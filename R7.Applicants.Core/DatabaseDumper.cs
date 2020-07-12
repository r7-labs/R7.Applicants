using System.IO;
using LiteDB;
using R7.Applicants.Core.Models;

namespace R7.Applicants.Core
{
    public static class DatabaseDumper
    {
        public static TextWriter DumpDatabase (ILiteDatabase db)
        {
            var json = Newtonsoft.Json.JsonSerializer.CreateDefault ();
            var writer = new StringWriter ();

            writer.WriteLine ("== Divisions:");
            var divisions = db.GetCollection<Division> ("Divisions");
            foreach (var division in divisions.FindAll ()) {
                json.Serialize (writer, division);
                writer.WriteLine ();
            }

            writer.WriteLine ();
            writer.WriteLine ("== EduForms:");
            var eduForms = db.GetCollection<EduForm> ("EduForms");
            foreach (var eduForm in eduForms.FindAll ()) {
                json.Serialize (writer, eduForm);
                writer.WriteLine ();
            }

            writer.WriteLine ();
            writer.WriteLine ("== Financings:");
            var financings = db.GetCollection<Financing> ("Financings");
            foreach (var financing in financings.FindAll ()) {
                json.Serialize (writer, financing);
                writer.WriteLine ();
            }

            writer.WriteLine ();
            writer.WriteLine ("== EduLevels:");
            var eduLevels = db.GetCollection<EduLevel> ("EduLevels");
            foreach (var eduLevel in eduLevels.FindAll ()) {
                json.Serialize (writer, eduLevel);
                writer.WriteLine ();
            }

            writer.WriteLine ();
            writer.WriteLine ("== EduPrograms:");
            var eduPrograms = db.GetCollection<EduProgram> ("EduPrograms");
            foreach (var eduProgram in eduPrograms.FindAll ()) {
                json.Serialize (writer, eduProgram);
                writer.WriteLine ();
            }

            writer.WriteLine ();
            writer.WriteLine ("== Applicants:");
            var applicants = db.GetCollection<Applicant> ("Applicants");
            foreach (var applicant in applicants.FindAll ()) {
                json.Serialize (writer, applicant);
                writer.WriteLine ();
            }

            return writer;
        }
    }
}
