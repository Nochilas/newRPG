using System;
using PGLib;

namespace Cataclisma2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bard Baard = new Bard(12, 15);

            Console.WriteLine(Baard.Str);
            Console.WriteLine(Baard.Dex);
        }
    }
}
