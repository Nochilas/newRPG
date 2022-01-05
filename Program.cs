using System;
using PGLib;

namespace Cataclisma2
{
    class Program
    {
        static void Main(string[] args)
        {
            PG pg;
            pg = PG.GeneratePG();
            
            foreach(int c in pg.Characteristics)
                Console.WriteLine(c);
            
            
        }
    }
}
