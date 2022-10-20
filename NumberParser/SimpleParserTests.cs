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
                SimpleParser parser = new SimpleParser();
                int result = parser.ParseAndSum(string.Empty);

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
    }
}
