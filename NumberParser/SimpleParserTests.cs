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
                    TestUtil.ShowMessage(testName, "Parse and sum shold have returned 0 on an empty string");
                }
                else
                {
                    TestUtil.ShowMessage(testName, "=> test passed!");
                }
            }
            catch (Exception e)
            {
                TestUtil.ShowMessage(testName, e.ToString());
            }
        }

        public static void TestReturnsSingleNumberWhenTheNumberIsProvided(string singleNumber)
        {
            string testName = MethodBase.GetCurrentMethod().Name;

            try
            {
                int result = SimpleParser.ParseAndSum(singleNumber);

                if (result != int.Parse(singleNumber))
                {
                    TestUtil.ShowMessage(testName, "The output number must be equals to the provided number");
                }
                else
                {
                    TestUtil.ShowMessage(testName, "=> test passed!");
                }
            }
            catch (Exception e)
            {
                TestUtil.ShowMessage(testName, e.ToString());
            }
        }
    }
}
