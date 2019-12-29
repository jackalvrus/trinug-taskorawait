using System;
using System.Threading.Tasks;

namespace TaskOrAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var worker = new Example1();
            try
            {
                await worker.ReturnTask();
                //await worker.AwaitTask();
                Console.WriteLine("Done.");
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
