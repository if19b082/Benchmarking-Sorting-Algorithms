``` ini

BenchmarkDotNet=v0.13.0, OS=macOS Big Sur 11.3.1 (20E241) [Darwin 20.4.0]
Apple M1 2.40GHz, 1 CPU, 8 logical and 8 physical cores
  [Host]     : Mono 6.12.0.122 (2020-02/c621c35ffa0 Wed), X64 
  DefaultJob : Mono 6.12.0.122 (2020-02/c621c35ffa0 Wed), X64 


```
|                            Method |       Mean |     Error |    StdDev |
|---------------------------------- |-----------:|----------:|----------:|
|     BubbleSortWithConcreteContent |  15.697 ns | 0.0166 ns | 0.0147 ns |
|  InsertionSortWithConcreteContent |   9.867 ns | 0.0156 ns | 0.0146 ns |
|       HeapSortWithConcreteContent | 172.230 ns | 0.7654 ns | 0.7160 ns |
|    BubbleSortWithReferenceContent |  15.651 ns | 0.0100 ns | 0.0093 ns |
| InsertionSortWithReferenceContent |  11.702 ns | 0.0847 ns | 0.0792 ns |
|      HeapSortWithReferenceContent | 156.306 ns | 0.5296 ns | 0.4695 ns |
