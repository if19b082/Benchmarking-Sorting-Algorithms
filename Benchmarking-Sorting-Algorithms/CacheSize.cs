using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchmarking_Sorting_Algorithms.Algorithm;
using System;
using System.Linq;

namespace Benchmarking_Sorting_Algorithms
{
    public class CacheSize
    {
        // ClearCache Methode --> jedoch keinen Vorteil entdeckt --> Neustart des Rechners zwischen den Benchmarks durchgeführt

        //[Benchmark]
        //public void ClearCache()
        //{
        //    int[] temp1 = Enumerable.Repeat(1, 7750000).ToArray();
        //    int[] temp2 = new int[7750000];
        //    Array.Copy(temp1, temp2, temp1.Length);
        //}

        private static int id;

        private static int entries = 320000;

        [Benchmark]
        public void GetID()
        {
            for (int i = 0; i >= _testArr.Length; i++)
            {
                id = i;
            }
        }

        // Array mit einer ID (int 32btit) und 12 Zahlen (long 64bit) --> 800bit pro Eintrag
        private static SortingAlgorithmCache.MyStruct test = new SortingAlgorithmCache.MyStruct { Id = id, Filler = new[] { 9223372036854775807, 9223372036854775807, 9223372036854775807, 9223372036854775807, 9223372036854775807, 9223372036854775807, 9223372036854775807, 9223372036854775807, 9223372036854775807, 9223372036854775807, 9223372036854775807, 9223372036854775807 } };

        // Hier gehört die Anzahl der Einträge geändert --> 320000 entsprechen 256 000 000 bit --> 32MB --> L3 Cache --> passt nicht in den Cache
        private static SortingAlgorithmCache.MyStruct[] _testArr = Enumerable.Repeat(test, entries).ToArray();

        [Benchmark]
        public void BubbleSortWithArrayCacheSize() => SortingAlgorithmCache.BubbleSort(_testArr);
        
        [Benchmark]
        public void InsertionSortWithArrayCacheSize() => SortingAlgorithmCache.InsertionSort(_testArr);
        
        [Benchmark]
        public void HeapSortWithArrayCacheSize() => SortingAlgorithmCache.HeapSort(_testArr);
    }
}