﻿using System;

namespace LogAn4.Tests
{
    public class StubService : IWebService
    {
        public Exception ToThrow;

        public void LogError(string message)
        {
            if (ToThrow != null)
                throw ToThrow;
        }
    }
}
