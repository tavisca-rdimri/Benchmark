using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Threading;

namespace BenchmarkForThreadVsTask
{
    public class ThreadVsTask
    {
        public void Fun1()
        {
            
            for (int i = 0; i < 1000; i++)
            {
                int a = i + 1;
                a *= 10;
            }
        }


        public async Task Fun2()
        {
            for (int i = 0; i < 1000; i++)
            {
                int a = i + 1;
                a *= 10;
            }
        }


        [Benchmark]
        public void ThreadTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(new ThreadStart(() => new ThreadVsTask().Fun1()));
                thread.Start();
                thread.Join();
            }
        }


        [Benchmark]
        public void TaskTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Run(async () =>
                {
                    var t = Fun2();
                    await Task.WhenAll(t);
                }).GetAwaiter().GetResult();
            }
        }
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<ThreadVsTask>();
        }
    }
}
