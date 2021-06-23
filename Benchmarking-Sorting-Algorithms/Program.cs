using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchmarking_Sorting_Algorithms.Algorithm;

namespace Benchmarking_Sorting_Algorithms
{
    internal static class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run<MemoryLocation>();
            BenchmarkRunner.Run<EntrySize>();

        }
    }
}