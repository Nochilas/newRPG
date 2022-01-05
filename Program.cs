using System;

// Separate standard (std) libs from external ones
using PGLib;

namespace Cataclisma2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Same Array.Sort(arr, new IComparerDerivedClass()) structure.
            // It sucks, but that's it folks
            PG pg = PG.GeneratePG(new PG());
            // Unboxing the PG since WE KNOW it's a Bard
            Bard b = PG.GeneratePG(new Bard()) as Bard;
            
            foreach(int c in pg.Characteristics)
                Console.WriteLine(c);
            foreach(int c in b.Characteristics)
                Console.WriteLine(c);
        }
    }
}
