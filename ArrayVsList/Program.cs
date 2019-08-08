using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace MyBenchmarkForArrayVsList
{
    public class ArrayVsList
    {
        [Benchmark]
        public void Array()
        {
            int[] a=new int[100] ;
            for (int i = 0; i < 100; i++)
            {
                a[i] = i;
            }
        }
        [Benchmark]
        public void List()
        {
            List<int> intList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                intList.Add(i);
            }
        }
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<ArrayVsList>();
        }
    }
}
