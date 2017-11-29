namespace ChainOfResponsibilitySample
{
    /// <summary>
    /// 障害を表す
    /// </summary>
    public class Issue
    {
        /// <summary>
        /// 障害管理番号を表す
        /// </summary>
        public int IssueNumber { get; private set; }

        public Issue(int issueNumber)
        {
            IssueNumber = issueNumber; //障害の発生
        }
    }
}
