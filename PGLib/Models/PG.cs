using System;

namespace PGLib.Models
{
    // The 7 chars of a given PG. Used in combination with indexers.
    // See Bard class for a couple of examples
    public enum Chars
    {
        Strength = 0,
        Constitution,
        Size,
        Dexterity,
        Intelligence,
        Power,
        Charisma
    }
    public class PG
    {
        public string Name { get; set; }

        public CharacterClass CharClass { get; set; }

        public CharacterRace CharRace { get; set; }

        //Strenght, dexterity, constitution, size, intelligence, power, charisma
        public int[] Characteristics { get; set; } = new int[7];

        // This is called indexer (it: indicizzatore). get and set functions
        // are mixed with lambda functions in order to take less writing effort
        // Used to get a property of the object through an index like an array (ex. PG[1] or PG[Chars.Strength])
        public int this [int i]
        {
            get => Characteristics[i];
            protected set => Characteristics[i] = value;
        }
        public int this [Chars c]
        {
            get => Characteristics[(int)c];
            protected set => Characteristics[(int)c] = value;
        }

        //Methods
        // public PG(CharacterClass charClass, CharacterRace charRace, string name)
        // {
        //     CharClass = charClass;
        //     CharRace = charRace;
        //     Name = name;
        // }

        public PG()
        {}
        
        public static PG GeneratePG(string name, CharacterClass charClass, CharacterRace charRace)
        {
            Random rnd = new Random();
            int[] charss = new int[7];

            for(int i = 0; i < charss.Length; i++)
                charss[i] = rnd.Next(charRace.CharMin[i], charRace.CharMax[i]);
            
            //TODO: Write charClass bonus

            return new PG()
            {
                Name = name,
                CharClass = charClass,
                CharRace = charRace,
                Characteristics = charss
            };
        }
    }
}