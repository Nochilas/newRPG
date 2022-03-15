using System;

namespace PGLib.Models
{
    public class Dwarf : CharacterRace
    {
        public Dwarf()
        {
            CharMin = new int[] { 12, 14, 9, 6, 8, 8, 6 };
            CharMax = new int[] { 22, 24, 12, 16, 18, 18, 16 };
            Name = "Dwarf";
        }
    }
}