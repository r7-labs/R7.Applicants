using R7.Applicants.Core.Models;

namespace R7.Applicants.Core.Parsers
{
    public class WorkbookParserContext
    {
        public WorkbookParserState State;

        public EduProgram EduProgram;

        public EduLevel EduLevel;

        public Division Division;

        public EduForm EduForm;

        public Applicant Applicant;

        public bool IsSveBlock;

        public WorkbookParserContext ()
        {
            State = WorkbookParserState.Initial;
        }
    }
}
