using System;
using System.Diagnostics;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
//using BenchmarkDotNet.Attributes.Columns;
//using BenchmarkDotNet.Attributes.Exporters;


namespace MyBenchmark
{
   public class StringVsStringBuilder
   {
        [Benchmark]
        public void StringBenchmark()
        {
            string str = "Rohit";
            for (int i = 0; i < 100; i++)
            {
                str += i;
            }
        }
        [Benchmark]
        public void StringBuilderBenchmark()
        {
            StringBuilder str1 = new StringBuilder("Rohit");
            for (int i = 0; i < 100; i++)
            {
                str1.Append(i);
            }
        }
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringVsStringBuilder>();
        }
    }
}
