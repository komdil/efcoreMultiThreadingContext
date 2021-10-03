using efcoreMultiThreadingContext;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace EFCoreMultiThreadingContextTest
{
    public class GetEntitiesTest : TestBase
    {
        [Fact]
        public void GetEntities_ShouldWorkOnMultiThreadingTest()
        {
            var tasks = new List<Task>();
            var students = TestDBContext.GetEntities<Student>();
            for (int i = 0; i < 15; i++)
            {
                tasks.Add(Task.Run(() => LoadStudentEntities(students)));
            }
            Task.WaitAll(tasks.ToArray());
        }

        void LoadStudentEntities<T>(EntityQuery<T> query) where T : class
        {
            foreach (var student in query)
            {

            }
        }
    }
}
