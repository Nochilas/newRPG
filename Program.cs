using System;

// Separate standard (std) libs from external ones
using PGLib;
using PGLib.Models;

namespace Cataclisma2;

class Program
{
    static void Main(string[] args)
    {
        // Same Array.Sort(arr, new IComparerDerivedClass()) structure.
        // It sucks, but that's it folks
        PG pg = PG.GeneratePG("Pippo", new Bard(), new Dwarf());
        
        foreach(int c in pg.Characteristics)
            Console.WriteLine(c);
        /*foreach(int c in b.Characteristics)
            Console.WriteLine(c);*/
        
        // string path = JSONSerializer.Serialize();
        // CharacterClass strama = JSONSerializer.Deserialize(path);

        // Console.WriteLine("-------");

        // foreach(int c in strama.Characteristics)
        //     Console.WriteLine(c);

        //TODO: Create Nuget pack
        //Testing xUnit
        //Create configuration file
        //Correct path creation
        //Use "using" for FileStream
        //Fix Serialize and Deserialize
    }
}
