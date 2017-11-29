using System;

namespace ChainOfResponsibilitySample
{
    public abstract class Support
    {
        private string _staffName;

        private Support _nextSupport;

        public Support(string staffName)
        {
            _staffName = staffName;
        }

        public Support SetNextSupport(Support nextSupport)
        {
            return _nextSupport = nextSupport;
        }

        public void SupportIssue(Issue issue)
        {
            if (Resolve(issue))
            {
                Console.WriteLine("問題" + issue.IssueNumber + "は" + _staffName + "が解決しました。");
            }
            else if (_nextSupport != null)
            {
                _nextSupport.SupportIssue(issue);
            }
            else
            {
                Console.WriteLine("問題" + issue.IssueNumber + "は現在のサポート体制では解決できませんでした。");
            }

        }

        protected abstract bool Resolve(Issue issue);

    }
}
