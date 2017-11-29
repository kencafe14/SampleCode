namespace ChainOfResponsibilitySample
{
    public class LimitSupport : Support
    {

        private int _limitIssueNumber;

        public LimitSupport(string staffName, int limitIssueNumber) : base(staffName)
        {

            _limitIssueNumber = limitIssueNumber;
        }

        protected override bool Resolve(Issue issue)
        {
            return issue.IssueNumber < _limitIssueNumber;
        }
    }
}
