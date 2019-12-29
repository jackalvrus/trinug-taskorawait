using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskOrAwait
{
    class ExampleBase
    {
        protected async Task DoTheWork()
        {
            await Task.CompletedTask;
            //throw new Exception("Exception from DoTheWork");
        }

        protected async Task<int> GetSomething()
        {
            return await Task.FromResult(3);
            //throw new Exception("Exception from GetSomething");
        }
    }
}
