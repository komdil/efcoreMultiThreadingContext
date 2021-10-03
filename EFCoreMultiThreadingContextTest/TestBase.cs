using System;

namespace EFCoreMultiThreadingContextTest
{
    public abstract class TestBase : IDisposable
    {
        protected TestDBContext TestDBContext { get; private set; }

        protected TestBase()
        {
            TestDBContext = new TestDBContext();
        }

        public void Dispose()
        {
            TestDBContext.Dispose();
            TestDBContext = null;
        }
    }
}
