using System;

namespace PGLib
{
    class PG
    {
        private int strength;
        public int Strength
        {
            get { return strength; }
            protected set
            {
                if (value < 0)
                    throw new Exception("Strength can never be negative");
                
                strength = value;
            }
        }

        private int dexterity;
        public int Dexterity
        {
            get { return dexterity; }
            protected set
            {
                if (value < 0)
                    throw new Exception("Dexterity can never be negative");
                
                dexterity = value;
            }
        }

        public PG(int str, int dex)
        {
            strength = str;
        }
        
        public static PG GeneratePG()
        {
            Random rnd = new Random();
            int strength = rnd.Next(8, 18);
            int dexterity = rnd.Next(8, 18);
            return new PG(strength, dexterity);
        }

    }
}
