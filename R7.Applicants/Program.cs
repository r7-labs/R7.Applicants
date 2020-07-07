using System;
using System.IO;
using LiteDB;
using R7.Applicants.Core.Models;
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

            DumpDatabase (db);

            db.Dispose ();
            File.Delete ("./lite.db");
        }

        static void DumpDatabase (ILiteDatabase db)
        {
            Console.WriteLine ();
            Console.WriteLine ("== Divisions:");
            var divisions = db.GetCollection<Division> ("Divisions");
            foreach (var division in divisions.FindAll ()) {
                Console.WriteLine (division.Id + " " + division.Title);
            }

            Console.WriteLine ();
            Console.WriteLine ("== EduForms:");
            var eduForms = db.GetCollection<EduForm> ("EduForms");
            foreach (var eduForm in eduForms.FindAll ()) {
                Console.WriteLine (eduForm.Id + " " + eduForm.Title);
            }

            Console.WriteLine ();
            Console.WriteLine ("== EduLevels:");
            var eduLevels = db.GetCollection<EduLevel> ("EduLevels");
            foreach (var eduLevel in eduLevels.FindAll ()) {
                Console.WriteLine (eduLevel.Id + " " + eduLevel.Title);
            }

            Console.WriteLine ();
            Console.WriteLine ("== Categories:");
            var categories = db.GetCollection<Category> ("Categories");
            foreach (var category in categories.FindAll ()) {
                Console.WriteLine (category.Id + " " + category.Title);
            }

            Console.WriteLine ();
            Console.WriteLine ("== EduPrograms:");
            var eduPrograms = db.GetCollection<EduProgram> ("EduPrograms");
            foreach (var eduProgram in eduPrograms.FindAll ()) {
                Console.WriteLine ("Id: " + eduProgram.Id + ", EduLevelId: " + eduProgram.EduLevelId + ", Title: " + eduProgram.Title);
            }

            Console.WriteLine ();
            Console.WriteLine ("== Applicants:");
            var applicants = db.GetCollection<Applicant> ("Applicants");
            foreach (var applicant in applicants.FindAll ()) {
                Console.WriteLine ("Id: " + applicant.Id + ", Name: " + applicant.Name + ", EduProgramId: " + applicant.EduProgramId);
            }
        }
    }
}
