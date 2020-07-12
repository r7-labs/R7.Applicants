using R7.Applicants.Models;

namespace R7.Applicants.Parsers
{
    public class WorkbookParserContext
    {
        public WorkbookParserState State;

        public EduProgram EduProgram;

        public EduLevel EduLevel;

        public Division Division;

        public EduForm EduForm;

        public Financing Financing;

        public Applicant Applicant;

        public bool IsSveBlock;

        public WorkbookParserContext ()
        {
            State = WorkbookParserState.Initial;
        }
    }
}
