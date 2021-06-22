using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchmarking_Sorting_Algorithms.Algorithm;

namespace Benchmarking_Sorting_Algorithms
{
    public class BubbleSortVsInsertionSortVsHeapSort
    {
        private readonly SortingAlgorithm.MyStruct[] _concreteArr = {
            new SortingAlgorithm.MyStruct{ Id = 10, Label = "a", Names = new[] { "Markus", "Thomas", "Fabian" } },
            new SortingAlgorithm.MyStruct{ Id = 8, Label = "b", Names = new[] { "Daniel", "Manuel", "Tobias" } },
            new SortingAlgorithm.MyStruct{ Id = 2, Label = "c", Names = new[] { "Stefan", "Ludwig", "Marko" } }
        };
        
        private static readonly SortingAlgorithm.MyStruct MyFirstStruct = new SortingAlgorithm.MyStruct{ Id = 10, Label = "a", Names = new[] { "Markus", "Thomas", "Fabian" } };
        private static readonly SortingAlgorithm.MyStruct MySecondStruct = new SortingAlgorithm.MyStruct{ Id = 8, Label = "b", Names = new[] { "Daniel", "Manuel", "Tobias" } };
        private static readonly SortingAlgorithm.MyStruct MyThirdStruct = new SortingAlgorithm.MyStruct{ Id = 2, Label = "c", Names = new[] { "Stefan", "Ludwig", "Marko" } };
        
        private readonly SortingAlgorithm.MyStruct[] _seperateArr = {
            MyFirstStruct,
            MySecondStruct,
            MyThirdStruct
        };
        
        private readonly SortingAlgorithmsStruct.MyStruct[] _structArray = {
            new SortingAlgorithmsStruct.MyStruct{ Id = 573, Label = "a", Names = new[] { "Markus", "Thomas", "Fabian" }, RandomNumbers = new[] {573,276,967,714,804, 613,209,382,999,946} },
            new SortingAlgorithmsStruct.MyStruct{ Id = 276, Label = "b", Names = new[] { "Daniel", "Manuel", "Tobias" }, RandomNumbers = new[] {1,76,24,231,432, 23,43,234,421,431} },
            new SortingAlgorithmsStruct.MyStruct{ Id = 967, Label = "c", Names = new[] { "Stefan", "Ludwig", "Marko" },RandomNumbers = new[] {214,213,32,43,65, 734,85,902,3,45} },
            new SortingAlgorithmsStruct.MyStruct{ Id = 714, Label = "d", Names = new[] { "Sven", "Edgar", "Leon" },RandomNumbers = new[] {22,732,754,32,765, 64,32,234,534,754} },
            new SortingAlgorithmsStruct.MyStruct{ Id = 804, Label = "e", Names = new[] { "Tom", "Jon", "Ron" }, RandomNumbers = new[] {11,231,432,923,531, 311,321,353,321,63}},
            new SortingAlgorithmsStruct.MyStruct{ Id = 613, Label = "f", Names = new[] { "Peter", "Petrus", "Petra" },RandomNumbers = new[] {532,692,63,433,632, 333,111,321,525,32} },
            new SortingAlgorithmsStruct.MyStruct{ Id = 209, Label = "g", Names = new[] { "Sara", "John", "Maxi" },RandomNumbers = new[] {949,848,555,333,136, 123,543,533,53,777} },
            new SortingAlgorithmsStruct.MyStruct{ Id = 382, Label = "h", Names = new[] { "Sevi", "Sebi", "Sabine" },RandomNumbers = new[] {123,312,321,543,982, 613,331,535,643,64} },
            new SortingAlgorithmsStruct.MyStruct{ Id = 999, Label = "i", Names = new[] { "Sonja", "Elena", "Fritz" },RandomNumbers = new[] {925,812,721,792,689, 589,239,932,982,367} },
            new SortingAlgorithmsStruct.MyStruct{ Id = 946, Label = "j", Names = new[] { "Jakob", "Jana", "Helena" },RandomNumbers = new[] {12,634,6,714,423, 623,385,194,286,396} },
        };
        
        private readonly int[] _intArray = {573,276,967,714,804, 613,209,382,999,946};
        
          
        [Benchmark]
        public void BubbleSortWithStructArray() => SortingAlgorithmsStruct.BubbleSort(_structArray);
        
        [Benchmark]
        public void InsertionSortWithStructArray() => SortingAlgorithmsStruct.InsertionSort(_structArray);
        
        [Benchmark]
        public void HeapSortWithWithStructArray() => SortingAlgorithmsStruct.HeapSort(_structArray);

        [Benchmark]
        public void BubbleSortWithIntArray() => SortingAlgorithmsInteger.BubbleSort(_intArray);
        
        [Benchmark]
        public void InsertionSortWithIntArray() => SortingAlgorithmsInteger.InsertionSort(_intArray);
        
        [Benchmark]
        public void HeapSortWithIntArray() => SortingAlgorithmsInteger.HeapSort(_intArray);
        
        
        [Benchmark]
        public void BubbleSortWithConcreteContent() => SortingAlgorithm.BubbleSort(_concreteArr);
        
        [Benchmark]
        public void InsertionSortWithConcreteContent() => SortingAlgorithm.InsertionSort(_concreteArr);
        
        [Benchmark]
        public void HeapSortWithConcreteContent() => SortingAlgorithm.HeapSort(_concreteArr);

        [Benchmark]
        public void BubbleSortWithReferenceContent() => SortingAlgorithm.BubbleSort(_seperateArr);
        
        [Benchmark]
        public void InsertionSortWithReferenceContent() => SortingAlgorithm.InsertionSort(_seperateArr);
        
        [Benchmark]
        public void HeapSortWithReferenceContent() => SortingAlgorithm.HeapSort(_seperateArr);
    }
    
    internal static class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run<BubbleSortVsInsertionSortVsHeapSort>();
        }
    }
}