using System;
using System.Diagnostics;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkForClassVsStructure
{
    public class Class
    {
       public int a, b;
    }
    public struct Structure
    {
       public int a, b;
    }

    public class ClassVsStructure
    {
        [Benchmark]
        public void ClassTest()
        {
            Class[] classTest = new Class[100];
            for(int i=0;i<100;i++)
            {
                classTest[i] = new Class();
                classTest[i].a = i;
                classTest[i].b = i;
            }
        }
        [Benchmark]
        public void StructureTest()
        {
            Structure[] structureTest = new Structure[100];
            for (int i = 0; i < 100; i++)
            {
                structureTest[i] = new Structure();
                structureTest[i].a = i;
                structureTest[i].b = i;
            }
        }
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<ClassVsStructure>();
        }
    }
}

