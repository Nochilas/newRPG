using System;

namespace PGLib
{
    public class PG
    {
        private int str;
        public int Str
        {
            get { return str; }
            protected set
            {
                if (value < 0)
                    throw new Exception("Strength can never be negative");
                
                str = value;
            }
        }

        private int dex;
        public int Dex
        {
            get { return dex; }
            protected set
            {
                if (value < 0)
                    throw new Exception("Dexterity can never be negative");
                
                dex = value;
            }
        }

        public PG(int strr, int dexx)
        {
            Str = strr;
            Dex = dexx;
        }
        
        public static PG GeneratePG()
        {
            Random rnd = new Random();
            int str = rnd.Next(8, 18);
            int dex = rnd.Next(8, 18);
            return new PG(str, dex);
        }

    }
}
