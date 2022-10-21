using System;
using System.Reflection;

namespace NumberParser
{
    public class SimpleParserTests
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            string testName = MethodBase.GetCurrentMethod().Name;

            try
            {
                int result = SimpleParser.ParseAndSum(string.Empty);

                if (result != 0)
                {
                    //calling the helper method
                    TestUtil.ShowProblem(testName, "Parse and sum shold have returned 0 on an empty string");
                }
            }
            catch (Exception e)
            {
                TestUtil.ShowProblem(testName, e.ToString());
            }
        }

        public static void TestReturnsNumberWWhenTheNumberIsProvided(string singleNumber)
        {
            string testName = MethodBase.GetCurrentMethod().Name;

            try
            {
                int result = SimpleParser.ParseAndSum(singleNumber);

                if (result != int.Parse(singleNumber))
                {
                    TestUtil.ShowProblem(testName, "The output number must be equals to the provided number");
                }
            }
            catch (Exception e)
            {
                TestUtil.ShowProblem(testName, e.ToString());
            }
        }
    }
}
