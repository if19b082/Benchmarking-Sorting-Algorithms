using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchmarking_Sorting_Algorithms.Algorithm;

namespace Benchmarking_Sorting_Algorithms
{
    internal static class Program
    {
        public static void Main()
        {
            // Variante - Arraygröße - in CacheSize.cs muss der Integer entries angepasst werden fürs Testen (Gesamtes Datenarray passt in den CPU-Cache / Array ist zu groß für den Cache)
            BenchmarkRunner.Run<CacheSize>();

            // Variante - Eintragsgröße (Array Eintrag ist ein simpler Integer / Array Eintrag ist ein komplexes Struct)
            BenchmarkRunner.Run<EntrySize>();

            // Variante - Speicherort (Array enthält direkt die konkreten Inhalte / Jeder einzelne Inhalt wird separat erzeugt (allokiert).)
            BenchmarkRunner.Run<MemoryLocation>();
        }
    }
}