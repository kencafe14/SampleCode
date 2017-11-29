namespace ChainOfResponsibilitySample
{
    public class SpecialSupport : Support
    {
        private int _specialNumber;

        public SpecialSupport(string staffName, int specialNumber) : base(staffName)
        {
            _specialNumber = specialNumber;
        }

        protected override bool Resolve(Issue issue)
        {
            return issue.IssueNumber == _specialNumber;
        }
    }
}
