namespace TestPoker
{
    using System;

    public class TestNotPassedException : Exception
    {
        public TestNotPassedException()
            : base()
        {
        }
        public TestNotPassedException(string message)
            : base(message)
        {
        }
    }
}
