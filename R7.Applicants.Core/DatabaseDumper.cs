using System;
using System.IO;
using LiteDB;
using R7.Applicants.Core.Models;

namespace R7.Applicants.Core
{
    public static class DatabaseDumper
    {
        public static void DumpDatabase (ILiteDatabase db)
        {
            var json = Newtonsoft.Json.JsonSerializer.CreateDefault ();
           
            Console.WriteLine ("== Divisions:");
            var writer = new StringWriter ();
            var divisions = db.GetCollection<Division> ("Divisions");
            foreach (var division in divisions.FindAll ()) {
                json.Serialize (writer, division);
                writer.WriteLine ();
            }
            Console.WriteLine (writer);

            Console.WriteLine ("== EduForms:");
            writer = new StringWriter ();
            var eduForms = db.GetCollection<EduForm> ("EduForms");
            foreach (var eduForm in eduForms.FindAll ()) {
                json.Serialize (writer, eduForm);
                writer.WriteLine ();
            }
            Console.WriteLine (writer);

            Console.WriteLine ("== EduLevels:");
            writer = new StringWriter ();
            var eduLevels = db.GetCollection<EduLevel> ("EduLevels");
            foreach (var eduLevel in eduLevels.FindAll ()) {
                json.Serialize (writer, eduLevel);
                writer.WriteLine ();
            }
            Console.WriteLine (writer);

            Console.WriteLine ("== Categories:");
            writer = new StringWriter ();
            var categories = db.GetCollection<Category> ("Categories");
            foreach (var category in categories.FindAll ()) {
                json.Serialize (writer, category);
                writer.WriteLine ();
            }
            Console.WriteLine (writer);

            Console.WriteLine ("== EduPrograms:");
            writer = new StringWriter ();
            var eduPrograms = db.GetCollection<EduProgram> ("EduPrograms");
            foreach (var eduProgram in eduPrograms.FindAll ()) {
                json.Serialize (writer, eduProgram);
                writer.WriteLine ();
            }
            Console.WriteLine (writer);

            Console.WriteLine ("== Applicants:");
            writer = new StringWriter ();
            var applicants = db.GetCollection<Applicant> ("Applicants");
            foreach (var applicant in applicants.FindAll ()) {
                json.Serialize (writer, applicant);
                writer.WriteLine ();
            }
            Console.WriteLine (writer);
        }
    }
}
