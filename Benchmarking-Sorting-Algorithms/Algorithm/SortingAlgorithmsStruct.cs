using System.Collections.Generic;

namespace Benchmarking_Sorting_Algorithms.Algorithm
{
    public class SortingAlgorithmsStruct
    {
        public static void BubbleSort(MyStruct[] myStruct)
        {
            for (var j = 0; j <= myStruct.Length - 2; j++) {
                for (var i = 0; i <= myStruct.Length - 2; i++)
                {
                    if (myStruct[i].Id <= myStruct[i + 1].Id) continue;
                    var temp = myStruct[i + 1].Id;
                    myStruct[i + 1] = myStruct[i];
                    myStruct[i].Id = temp;
                }
            }
        }
        public static void InsertionSort(MyStruct[] myStruct)
        {
            for (var i = 0; i < myStruct.Length - 1; i++)
            {
                for (var j = i + 1; j > 0; j--)
                {
                    if (myStruct[j - 1].Id <= myStruct[j].Id) continue;
                    var temp = myStruct[j - 1].Id;
                    myStruct[j - 1] = myStruct[j];
                    myStruct[j].Id = temp;
                }
            }
        }
        public static void HeapSort(MyStruct[] myStruct)
        {
            var length = myStruct.Length;
            for (var i = length / 2 - 1; i >= 0; i--)
            {
                Heapify(myStruct, length, i);
            }
            for (var i = length - 1; i >= 0; i--)
            {
                var temp = myStruct[0];
                myStruct[0] = myStruct[i];
                myStruct[i] = temp;
                Heapify(myStruct, i, 0);
            }
        }
        
        private static void Heapify(IList<MyStruct> array, int length, int i)
        {
            while (true)
            {
                var largest = i;
                var left = 2 * i + 1;
                var right = 2 * i + 2;
                if (left < length && array[left].Id > array[largest].Id)
                {
                    largest = left;
                }

                if (right < length && array[right].Id > array[largest].Id)
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

        public struct MyStruct
        {
            public int Id;
            public string Label;
            public string[] Names;
            public int[] RandomNumbers;
        }


    }
}