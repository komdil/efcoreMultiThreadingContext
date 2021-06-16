using EFCoreMultiThreading;
using System;
using System.Collections.Generic;

namespace Microsoft.EntityFrameworkCore.Query.Internal
{
    public class EntityQueryable<T> where T : Student
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
