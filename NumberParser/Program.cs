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
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}; {e.InnerException?.Message}");
            }
        }
    }
}