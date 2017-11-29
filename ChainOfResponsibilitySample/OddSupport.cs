namespace ChainOfResponsibilitySample
{
    public class OddSupport : Support
    {
        public OddSupport(string staffName) : base(staffName)
        {
        }

        protected override bool Resolve(Issue issue)
        {
            return issue.IssueNumber % 2 == 1;
        }
    }
}
