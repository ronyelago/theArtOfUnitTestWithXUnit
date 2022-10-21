using System;

namespace NumberParser
{
    internal class Program
    {
        static void Main(string [] args)
        {
            try
            {
                SimpleParserTests.TestReturnsZeroWhenEmptyString();
                SimpleParserTests.TestReturnsNumberWhenTheNumberIsProvided("34");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}; {e.InnerException?.Message}");
            }
        }
    }
}