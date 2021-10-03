using System.Collections.Generic;
using System.Linq;

namespace efcoreMultiThreadingContext
{
    public class EntityQuery<T> where T : class
    {
        IQueryable<T> SourceQuery { get; }

        public EntityQuery(IQueryable<T> source)
        {
            SourceQuery = source;
        }

        public IEnumerator<T> GetEnumerator()
        {
            lock (SourceQuery.Provider)
            {
                return SourceQuery.GetEnumerator();
            }
        }
    }
}
