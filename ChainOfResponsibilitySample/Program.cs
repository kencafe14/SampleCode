using System;

namespace ChainOfResponsibilitySample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Support limitSupport = new LimitSupport("Nagatomo", 3);
            Support oddSupport = new OddSupport("Kagawa");
            Support SpecialSupport = new SpecialSupport("Honda", 4);

            limitSupport.SetNextSupport(oddSupport).SetNextSupport(SpecialSupport);

            var IssueCount = 6;
            //　6件の問題が発生
            for (int i = 1; i <= IssueCount; i++)
            {
                limitSupport.SupportIssue(new Issue(i));
            }

            Console.ReadKey();
        }
    }
}
