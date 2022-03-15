using System;

namespace PGLib.Models
{
    public class CharacterRace
    {
        public string Name { get; set; }
        public int[] CharMin { get; set; } = new int[7];
        public int[] CharMax { get; set; } = new int[7];
    }
}