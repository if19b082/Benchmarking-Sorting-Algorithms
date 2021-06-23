using BenchmarkDotNet.Attributes;
using Benchmarking_Sorting_Algorithms.Algorithm;

namespace Benchmarking_Sorting_Algorithms
{
    public class MemoryLocation
    {
        private readonly SortingAlgorithm.MyStruct[] _concreteArr =
        {
            new SortingAlgorithm.MyStruct {Id = 10, Label = "a", Names = new[] {"Markus", "Thomas", "Fabian"}},
            new SortingAlgorithm.MyStruct {Id = 8, Label = "b", Names = new[] {"Daniel", "Manuel", "Tobias"}},
            new SortingAlgorithm.MyStruct {Id = 2, Label = "c", Names = new[] {"Stefan", "Ludwig", "Marko"}}
        };

        private static readonly SortingAlgorithm.MyStruct MyFirstStruct = new SortingAlgorithm.MyStruct
            {Id = 10, Label = "a", Names = new[] {"Markus", "Thomas", "Fabian"}};

        private static readonly SortingAlgorithm.MyStruct MySecondStruct = new SortingAlgorithm.MyStruct
            {Id = 8, Label = "b", Names = new[] {"Daniel", "Manuel", "Tobias"}};

        private static readonly SortingAlgorithm.MyStruct MyThirdStruct = new SortingAlgorithm.MyStruct
            {Id = 2, Label = "c", Names = new[] {"Stefan", "Ludwig", "Marko"}};

        private readonly SortingAlgorithm.MyStruct[] _seperateArr =
        {
            MyFirstStruct,
            MySecondStruct,
            MyThirdStruct
        };

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
}