﻿using System;

namespace NumberParser
{
    public static class SimpleParser
    {
        public static int ParseAndSum(string numbers)
        {
            if (numbers.Length == 0)
                return 0;

            if (!numbers.Contains(","))
                return int.Parse(numbers);
            else
                throw new InvalidOperationException("I can only handle 0 or 1 numbers for now!");
        }
        
    }
}
