using System;

namespace PGLib
{
    public class PG
    {
        #region Fields
        public int[] Characteristics { get; protected set; } = new int[7];

        #endregion

        #region Methods

        
        //Strenght, dexterity, constitution, size, intelligence, power, charisma
        public PG(int str, int dex, int con, int size, int intel, int pow, int ch)
        {
            Characteristics[0] = str;
            Characteristics[1] = dex;
            Characteristics[2] = con;
            Characteristics[3] = size;
            Characteristics[4] = intel;
            Characteristics[5] = pow;
            Characteristics[6] = ch;
        }

        public static PG GeneratePG()
        {
            Random rnd = new Random();
            
            int str = rnd.Next(8, 18);
            int dex = rnd.Next(8, 18);
            int con = rnd.Next(8, 18);
            int size = rnd.Next(8, 18);
            int intel = rnd.Next(8, 18);
            int pow = rnd.Next(8, 18);
            int ch = rnd.Next(8, 18);
            
            return new PG(str, dex, con, size, intel, pow, ch);
        }

        #endregion
    }
}
