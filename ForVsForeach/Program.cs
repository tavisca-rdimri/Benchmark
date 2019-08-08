using System;
using System.Diagnostics;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
namespace MyBenchmarkForForVsForeach
{
    public class ForVsForeach
    {
        [Benchmark]
        public void For()
        {
            int[] a = new int[100];
            for (int i = 0; i < 100; i++)
            {
                a[i] = i;
            }
            for(int i=0;i<100;i++)
            {
                a[i] = a[i] + 1;
            }
        }
        [Benchmark]
        public void Foreach()
        {
            int[] a = new int[100];
            for (int i = 0; i < 100; i++)
            {
                a[i] = i;
            }
            foreach(int num in a)
            {
                a[num] = a[num] + 1;
            }
        }
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<ForVsForeach>();
        }
    }
}
