using System;

namespace PGLib
{
    // The 7 chars of a given PG. Used in combination with indexers.
    // See Bard class for a couple of examples
    public enum Chars
    {
        Strength = 0,
        Dexterity,
        Constitution,
        Size,
        Intelligence,
        Power,
        Charisma
    }

    public class PG
    {
        #region Fields

        public int[] Characteristics { get; protected set; } = new int[7];

        // This is called indexer (it: indicizzatore). get and set functions
        // are mixed with lambda functions in order to take less writing effort
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

        #endregion

        #region Methods
        
        //TODO: Set chars to 0 'cause why not
        public PG() {}

        //Strenght, dexterity, constitution, size, intelligence, power, charisma
        public PG(int[] charss)
        {
            for(int i = 0; i < Characteristics.Length; i++)
                Characteristics[i] = charss[i];
        }

        // Derived classes use this function to generate a new PG as they want.
        // This one simply randomizes chars
        protected virtual PG Generate()
        {
            Random rnd = new Random();
            int[] charss = new int[7];

            for(int i = 0; i < charss.Length; i++)
                charss[i] = rnd.Next(8, 18);
            
            return new PG(charss);
        }

        // This function will use an instance of a derived class of PG class
        // and use its Generate function. See main function for an example
        public static PG GeneratePG(PG generator)
        {
            return generator.Generate();
        }

        #endregion
    }
}
