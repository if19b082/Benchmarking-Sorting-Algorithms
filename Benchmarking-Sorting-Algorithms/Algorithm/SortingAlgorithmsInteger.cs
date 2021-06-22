using System.Collections.Generic;

namespace Benchmarking_Sorting_Algorithms.Algorithm
{
    public class SortingAlgorithmsInteger
    {
        public static void BubbleSort(int[] intArray)
        {
            for (var j = 0; j <= intArray.Length - 2; j++) {
                for (var i = 0; i <= intArray.Length - 2; i++)
                {
                    if (intArray[i] <= intArray[i + 1]) continue;
                    var temp = intArray[i + 1];
                    intArray[i + 1] = intArray[i];
                    intArray[i] = temp;
                }
            }
        }
        public static void InsertionSort(int[] intArray)
        {
            for (var i = 0; i < intArray.Length - 1; i++)
            {
                for (var j = i + 1; j > 0; j--)
                {
                    if (intArray[j - 1] <= intArray[j]) continue;
                    var temp = intArray[j - 1];
                    intArray[j - 1] = intArray[j];
                    intArray[j] = temp;
                }
            }
        }
        public static void HeapSort(int[] intArray)
        {
            var length = intArray.Length;
            for (var i = length / 2 - 1; i >= 0; i--)
            {
                Heapify(intArray, length, i);
            }
            for (var i = length - 1; i >= 0; i--)
            {
                var temp = intArray[0];
                intArray[0] = intArray[i];
                intArray[i] = temp;
                Heapify(intArray, i, 0);
            }
        }
        
        private static void Heapify(IList<int> array, int length, int i)
        {
            while (true)
            {
                
                var largest = i;
                var left = 2 * i + 1;
                var right = 2 * i + 2;
                if (left < length && array[left] > array[largest])
                {
                    largest = left;
                }

                if (right < length && array[right] > array[largest])
                {
                    largest = right;
                }

                if (largest == i) return;
                var swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                i = largest;
            }
        }
    }
}