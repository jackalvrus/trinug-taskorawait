using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskOrAwait
{
    class Example2 : ExampleBase
    {
        public Task<int> ReturnTask()
        {
            return GetSomething();
        }

        public async Task<int> AwaitTask()
        {
            return await GetSomething();
        }
    }
}
