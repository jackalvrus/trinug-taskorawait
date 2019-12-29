using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskOrAwait
{
    class Example1 : ExampleBase
    {
        public Task ReturnTask()
        {
            return DoTheWork();
        }

        public async Task AwaitTask()
        {
            await DoTheWork();
        }
    }
}
